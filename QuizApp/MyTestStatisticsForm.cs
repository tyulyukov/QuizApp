using ClientServer;
using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class MyTestStatisticsForm : Form
    {
        private List<MyTestStatisticPresenter> MyTestStatistics = new List<MyTestStatisticPresenter>();
        private Client client;
        private Test test;

        public MyTestStatisticsForm(Client _client, Test _test)
        {
            InitializeComponent();

            client = _client;
            test = _test;
        }

        private void UpdateStatistics()
        {
            Response response;
            StatisticsCollection statisticsCollection;

            try
            {
                client.Send(new Request(RequestType.GetTestStatistics, client.Nickname, test.Id.ToString()));

                response = client.Receive();
                statisticsCollection = response.Parameter as StatisticsCollection;
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            MyTestStatistics.Clear();

            foreach (var stat in statisticsCollection.Statistics)
                MyTestStatistics.Add(new MyTestStatisticPresenter(stat));

            var orderedStats = MyTestStatistics.OrderByDescending(stat => stat.PresentableStatistic.PassDate).ToList();

            AddInPanel(orderedStats);
        }

        public void AddInPanel(List<MyTestStatisticPresenter> statistics)
        {
            panelMyStatistics.Controls.Clear();

            int lastY = 0;
            foreach (var statistic in statistics)
            {
                var panelStatistic = statistic.Present();
                panelStatistic.Location = new Point(0, lastY);

                panelMyStatistics.Controls.Add(panelStatistic);
                lastY += panelStatistic.Height + 10;
            }
        }

        private void StatisticsForm_Load(object sender, EventArgs e) => UpdateStatistics();

        private void buttonUpdateMyStatistics_Click(object sender, EventArgs e) => UpdateStatistics();
    }
}
