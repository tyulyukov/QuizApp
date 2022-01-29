using ClientServer;
using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class MyStatisticsForm : Form
    {
        private List<MyStatisticPresenter> MyStatistics = new List<MyStatisticPresenter>();
        private Client client;

        public MyStatisticsForm(Client _client)
        {
            InitializeComponent();

            client = _client;
        }

        private void UpdateStatistics()
        {
            Response response;
            StatisticsCollection statisticsCollection;

            try
            {
                client.Send(new Request(RequestType.GetMyStatistics, client.Nickname, "i want to load my statistics"));

                response = client.Receive();
                statisticsCollection = response.Parameter as StatisticsCollection;
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            MyStatistics.Clear();

            foreach (var stat in statisticsCollection.Statistics)
                MyStatistics.Add(new MyStatisticPresenter(stat));

            var orderedStats = MyStatistics.OrderBy(stat => stat.PresentableStatistic.PassDate).ToList();

            AddInPanel(orderedStats);
        }

        public void AddInPanel(List<MyStatisticPresenter> statistics)
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