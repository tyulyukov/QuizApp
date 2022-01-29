using System;
using System.Drawing;
using System.Windows.Forms;
using WindowControllers;
using ClientServer;

namespace QuizApp
{
    public partial class LoginForm : Form
    {
        public WindowController window;
        public MouseController mouse;
        private Client client;

        public LoginForm()
        {
            InitializeComponent();

            mouse = new MouseController();
            window = new WindowController(this);

            client = new Client(Client.CurrentHostIp, 1000);
        }

        #region Window Control

        private void panelAppMenu_MouseDown(object sender, MouseEventArgs e) => mouse.Push();

        private void panelAppMenu_MouseUp(object sender, MouseEventArgs e) => mouse.Push();

        private void panelAppMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse.IsPushed)
                return;

            if (mouse.Distance == Point.Empty)
                mouse.SetDistance(e.Location);

            SetDesktopLocation(MousePosition.X - mouse.Distance.X, MousePosition.Y - mouse.Distance.Y);
        }
        private void buttonCloseApp_Click(object sender, EventArgs e) => window.Close();

        private void buttonMaximizeApp_Click(object sender, EventArgs e)
        {
            if (window.Normalized)
                window.Maximize();
            else
                window.Normalize();
        }

        private void buttonMinimizeApp_Click(object sender, EventArgs e) => window.Minimize();

        private void buttonCloseApp_MouseEnter(object sender, EventArgs e) => buttonCloseApp.BackColor = Color.Red;

        private void buttonCloseApp_MouseLeave(object sender, EventArgs e) => buttonCloseApp.BackColor = Color.Empty;

        private void buttonMinOrMax_MouseEnter(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.Gray;

        private void buttonMinOrMax_MouseLeave(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.Empty;

        #endregion

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
                textBoxPassword.PasswordChar = Char.MinValue;
            else
                textBoxPassword.PasswordChar = '•';
        }

        private void labelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxUsername.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            checkBoxShow.Checked = false;

            RegistrationForm registration = new RegistrationForm(client);
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Заполните поле Никнейм!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните поле Пароль!");
                return;
            }

            String passwordHash = Encoder.GetHash(textBoxPassword.Text);

            try
            {
                client.Connect();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            System.Threading.Thread.Sleep(250);

            try
            {
                client.Send(new Request(RequestType.Authorization, textBoxUsername.Text, passwordHash));
                Response response = client.Receive();

                if (!response.Result)
                {
                    MessageBox.Show("Неправильный никнейм или пароль!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            client.Nickname = textBoxUsername.Text;

            textBoxUsername.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            checkBoxShow.Checked = false;

            QuizForm quizApp = new QuizForm(client);
            this.Hide();
            quizApp.ShowDialog();
            if (!this.Disposing && !this.IsDisposed)
                this.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            Application.Exit();
        }
    }
}
