using System;
using System.Drawing;
using System.Windows.Forms;
using WindowControllers;
using ClientServer;
using System.Linq;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        public readonly TestsForm testsForm;
        public readonly TestCreatorForm testCreatorForm;
        public readonly PersonalAreaForm personalAreaForm;
        private Form activeMenuForm;

        private MouseController mouse;
        private WindowController window;
        
        private Client client;

        public QuizForm(Client _client)
        {
            InitializeComponent();

            mouse = new MouseController();
            window = new WindowController(this);

            client = _client;
            labelNickname.Text = client.Nickname;

            testsForm = new TestsForm(client);
            testCreatorForm = new TestCreatorForm(client);
            personalAreaForm = new PersonalAreaForm(client);

            panelMenu.Visible = false;
            panelMenu.Width = 270;
            panelMenu.Location = new Point(669, 95);

            OpenMenuTab(testsForm);
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

        private void buttonTests_Click(object sender, EventArgs e) => OpenMenuTab(testsForm);

        private void buttonCreateTest_Click(object sender, EventArgs e) => OpenMenuTab(testCreatorForm);

        #endregion 

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (activeMenuForm.Name != "TestsForm")
                OpenMenuTab(testsForm);

            testsForm.SearchTests(textBoxSearch.Text);
            listBoxSearchVariants.Items.Clear();
            listBoxSearchVariants.Visible = false;
            panelMenu.Visible = false;
        }

        private void buttonAccount_Click(object sender, EventArgs e) => panelMenu.Visible = !panelMenu.Visible;

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();  

            Application.Exit();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxSearchVariants.Visible = !String.IsNullOrWhiteSpace(textBoxSearch.Text);
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
                return;

            listBoxSearchVariants.Items.Clear();

            var searchedTests = testsForm.Tests.Where(test => test.PresentableTest.Name.ToLower().StartsWith(textBoxSearch.Text.ToLower().Trim()))
                                               .Select(test => test.PresentableTest).ToList();

            if (searchedTests.Count == 0)
            {
                listBoxSearchVariants.Visible = false;
                return;
            }

            foreach (var test in searchedTests)
                listBoxSearchVariants.Items.Add(test.Name);

            listBoxSearchVariants.Height = searchedTests.Count * listBoxSearchVariants.ItemHeight + 4;

            if (listBoxSearchVariants.Height > 194)
                listBoxSearchVariants.Height = 194;
        }

        private void listBoxSearchVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearchVariants.Focused == false)
                return;

            panelMenu.Visible = false;
            textBoxSearch.Text = listBoxSearchVariants.Items[listBoxSearchVariants.SelectedIndex].ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            Application.Exit();
        }

        private void buttonPersonalArea_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            Hide();
            personalAreaForm.ShowDialog();

            if (!Disposing && !IsDisposed)
                Show();
        }

        private void buttonMain_Click(object sender, EventArgs e) => panelMenu.Visible = false;
    }
}
