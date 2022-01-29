using System;
using System.Drawing;
using System.Windows.Forms;
using ClientServer;
using QuizLibrary;
using WindowControllers;

namespace QuizApp
{
    public partial class RegistrationForm : Form
    {
        public WindowController window;
        public MouseController mouse;
        private Client client;

        public RegistrationForm(Client _client)
        {
            InitializeComponent();

            mouse = new MouseController();
            window = new WindowController(this);

            client = _client;
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
            {
                textBoxPassword.PasswordChar = char.MinValue;
                textBoxRepeatPassword.PasswordChar = char.MinValue;
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxRepeatPassword.PasswordChar = '•';
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            Application.Exit();
        }

        private void labelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FormClosing -= RegistrationForm_FormClosing;
            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
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
            else if (String.IsNullOrWhiteSpace(textBoxRepeatPassword.Text))
            {
                MessageBox.Show("Заполните поле с повтором пароля!");
                return;
            }

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Не правильный повтор пароля!");
                return;
            }

            if (!Username.Validate(textBoxUsername.Text))
            {
                MessageBox.Show($"Никнейм должен содержать более {Username.MinLength} и менее {Username.MaxLength} символов.\nНикнейм не должен содержать пробелы.\nНикнейм не должен содержать спец. символы!");
                return;
            }
            else if (!Password.Validate(textBoxPassword.Text))
            {
                MessageBox.Show($"Пароль должен содержать более {Password.MinLength} символов и менее {Password.MaxLength} символов.\nПароль не должен содержать пробелы.\nПароль должен содержать буквы и цифры!");
                return;
            }

            try
            {
                client.Connect();

                client.Send(new Request(RequestType.IsNicknameExisting, textBoxUsername.Text, "is this nickname existing?"));
                Response response = client.Receive();

                if (response.Result)
                {
                    MessageBox.Show("Такой никнейм уже занят!");
                    return;
                }

                client.Send(new Request(RequestType.Registration, textBoxUsername.Text, ClientServer.Encoder.GetHash(textBoxPassword.Text)));
                response = client.Receive();

                if (!response.Result)
                {
                    MessageBox.Show("Не удалось зарегистрировать пользователя");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            client.Nickname = textBoxUsername.Text;

            QuizForm quizApp = new QuizForm(client);
            this.Hide();
            quizApp.ShowDialog();
            this.FormClosing -= RegistrationForm_FormClosing;
            this.Close();
        }
    }
}
