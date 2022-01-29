using ClientServer;
using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class TestsForm : Form
    {
        public List<TestPresenter> Tests = new List<TestPresenter>();

        private Client client;

        public TestsForm(Client _client)
        {
            InitializeComponent();

            client = _client;
        }

        public void SearchTests(String name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                UpdateTests();
                return;
            }

            var searchedTests = Tests.Where(test => test.PresentableTest.Name.ToLower().Contains(name.ToLower().Trim())).ToList();

            AddInPanel(searchedTests);
        }

        public void UpdateTests()
        {
            Response response;
            TestsCollection testsCollection;

            try
            {
                client.Send(new Request(RequestType.GetTests, client.Nickname, "i want to load tests"));

                response = client.Receive();
                testsCollection = response.Parameter as TestsCollection;
                
                foreach (var test in testsCollection.Tests)
                    foreach (var question in test.Questions)
                        foreach (var answer in question.AnswersOptions)
                            answer.Right = false;
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            Tests.Clear();

            foreach (var test in testsCollection.Tests)
                Tests.Add(new TestPresenter(test, ButtonPass_Click));

            var randomOrderedTests = Tests.OrderBy(test => Guid.NewGuid()).ToList();

            AddInPanel(randomOrderedTests);
        }

        private void ButtonPass_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Test currentTest = button.Tag as Test;

            QuizForm parent = ParentForm as QuizForm;
            parent.OpenMenuTab(new PassingTestForm(client, currentTest));
        }

        public void AddInPanel(List<TestPresenter> presenters)
        {
            panelTests.Controls.Clear();

            int lastY = 0;
            foreach (var testPresenter in presenters)
            {
                var panelTest = testPresenter.Present();
                panelTest.Location = new Point(0, lastY);

                panelTests.Controls.Add(panelTest);
                lastY += panelTest.Height + 10;
            }
        }

        private void buttonUpdateTests_Click(object sender, EventArgs e) => UpdateTests();

        private void TestsForm_Shown(object sender, EventArgs e) => UpdateTests();

        private void buttonConnectTest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxTestCode.Text))
                return;

            Test test;
            try
            {
                test = Tests.FirstOrDefault(t => t.PresentableTest.Id == Guid.Parse(textBoxTestCode.Text)).PresentableTest;

                if (test == null)
                {
                    client.Send(new Request(RequestType.GetTestById, client.Nickname, textBoxTestCode.Text));
                    Response response = client.Receive();

                    test = response.Parameter as Test;
                    
                    if (test == null)
                        return;

                    Tests.Add(new TestPresenter(test, ButtonPass_Click));
                }
            }
            catch { MessageBox.Show("Неверный идентификатор"); return; }

            QuizForm parent = ParentForm as QuizForm;
            parent.OpenMenuTab(new PassingTestForm(client, test));
        }
    }
}
