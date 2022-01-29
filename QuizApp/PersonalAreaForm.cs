using ClientServer;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowControllers;

namespace QuizApp
{
    public partial class PersonalAreaForm : Form
    {
        public MyTestsForm myTestsForm;
        public MyStatisticsForm statisticsForm;
        private Form activeMenuForm;

        private Client client;

        private MouseController mouse;
        private WindowController window;

        public PersonalAreaForm(Client _client)
        {
            InitializeComponent();

            client = _client;

            mouse = new MouseController();
            window = new WindowController(this);

            panelMenu.Visible = false;
            panelMenu.Width = 270;
            panelMenu.Location = new Point(669, 95);

            myTestsForm = new MyTestsForm(client);
            statisticsForm = new MyStatisticsForm(client);

            labelNickname.Text = client.Nickname;

            OpenMenuTab(myTestsForm);
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

        #region Menu Control

        public void OpenMenuTab(Form childForm)
        {
            if (activeMenuForm != null)
            {
                activeMenuForm.Hide();
                panelTests.Controls.Remove(activeMenuForm);
            }

            activeMenuForm = childForm;
            activeMenuForm.TopLevel = false;
            activeMenuForm.Dock = DockStyle.Fill;

            panelTests.Controls.Add(activeMenuForm);
            activeMenuForm.BringToFront();
            activeMenuForm.Show();

            panelMenu.Visible = false;
        }

        #endregion 

        private void PersonalAreaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            Application.Exit();
        }

        private void buttonPersonalArea_Click(object sender, EventArgs e) => panelMenu.Visible = false;

        private void buttonMain_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            FormClosing -= PersonalAreaForm_FormClosing;
            Hide();
        }

        private void buttonAccount_Click(object sender, EventArgs e) => panelMenu.Visible = !panelMenu.Visible;

        private void buttonMyTests_Click(object sender, EventArgs e) => OpenMenuTab(myTestsForm);

        private void buttonStatistics_Click(object sender, EventArgs e) => OpenMenuTab(statisticsForm);

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            Application.Exit();
        }
    }
}
