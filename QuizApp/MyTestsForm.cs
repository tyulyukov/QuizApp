using ClientServer;
using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class MyTestsForm : Form
    {
        private List<MyTestPresenter> MyTests = new List<MyTestPresenter>();

        private Client client;

        public MyTestsForm(Client _client)
        {
            InitializeComponent();

            client = _client;
        }

        private void UpdateTests()
        {
            Response response;
            TestsCollection testsCollection;

            try
            {
                client.Send(new Request(RequestType.GetMyTests, client.Nickname, "i want to load my tests"));

                response = client.Receive();
                testsCollection = response.Parameter as TestsCollection;
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            MyTests.Clear();

            foreach (var test in testsCollection.Tests)
                MyTests.Add(new MyTestPresenter(test, ButtonDeleteTestClick, ButtonEditTestClick, ButtonStatisticsClick));

            var orderedTests = MyTests.OrderBy(test => test.PresentableTest.Name).ToList();

            AddInPanel(orderedTests);
        }

        private void ButtonDeleteTestClick(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            Test test = button.Tag as Test;
            Response response;

            if (MessageBox.Show($"Вы действительно хотите удалить тест <{test.Name}>?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                client.Send(new Request(RequestType.DeleteTest, client.Nickname, $"Delete <{test.Name}> test", test));

                response = client.Receive();
                
                if (!response.Result)
                {
                    MessageBox.Show("Не удалось удалить тест");
                    return;
                }

                UpdateTests();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }
        }

        private void ButtonEditTestClick(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            Test test = button.Tag as Test;

            PersonalAreaForm parent = ParentForm as PersonalAreaForm;
            parent.OpenMenuTab(new TestEditorForm(client, test));
        }

        private void ButtonStatisticsClick(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            Test test = button.Tag as Test;

            PersonalAreaForm parent = ParentForm as PersonalAreaForm;
            parent.OpenMenuTab(new MyTestStatisticsForm(client, test));
        }

        private void AddInPanel(List<MyTestPresenter> presenters)
        {
            panelMyTests.Controls.Clear();

            int lastY = 0;
            foreach (var testPresenter in presenters)
            {
                var panelTest = testPresenter.Present();
                panelTest.Location = new Point(0, lastY);

                panelMyTests.Controls.Add(panelTest);
                lastY += panelTest.Height + 10;
            }
        }

        private void MyTestsForm_Shown(object sender, EventArgs e) => UpdateTests();

        private void buttonUpdateTests_Click(object sender, EventArgs e) => UpdateTests();
    }
}
