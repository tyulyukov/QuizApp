using System;
using System.Windows.Forms;
using ClientServer;
using QuizLibrary;

namespace QuizApp
{
    public partial class PassingTestForm : Form
    {
        private static readonly TimeSpan OneSecond = new TimeSpan(0, 0, 1);

        private Test test;
        private TestPassing passing;
        private Client client;
        private Timer passingTimer;
        private TimeSpan passingTime;

        public PassingTestForm(Client _client, Test _test)
        {
            InitializeComponent();

            client = _client;

            test = _test;
            passing = new TestPassing(test);
            panelTest.Controls.Add(passing.Present());

            passingTime = new TimeSpan(0, 0, 0);
            passingTimer = new Timer();
            passingTimer.Interval = 1000;
            passingTimer.Tick += PassingTimer_Tick;
            passingTimer.Start();
        }

        private void PassingTimer_Tick(object sender, EventArgs e)
        {
            passingTime = passingTime.Add(OneSecond);
            labelPassingTime.Text = passingTime.ToString();
        }

        private void buttonSendAnswers_Click(object sender, EventArgs e)
        {
            passingTimer.Stop();
            passing.Time = passingTime;
            passing.Date = DateTime.Now;

            try
            {
                client.Send(new Request(RequestType.CheckingAnswers, client.Nickname, $"Check my answers ot test: {passing.CurrentTest.Id}", passing.Answers));
                Response response = client.Receive();

                if (!response.Result)
                {
                    MessageBox.Show("Не удалось проверить результаты");
                    return;
                }

                MessageBox.Show(response.Message);

                passing = new TestPassing(test);
                panelTest.Controls.Clear();
                panelTest.Controls.Add(passing.Present());
            }
            catch
            {
                MessageBox.Show("Не удалось установить связь с сервером");
                return;
            }
            finally
            {
                ReturnToMainMenu();
            }
        }

        private void labelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReturnToMainMenu();

        private void ReturnToMainMenu()
        {
            passingTimer.Stop();
            QuizForm parent = ParentForm as QuizForm;
            parent.OpenMenuTab(parent.testsForm);
        }
    }
}
