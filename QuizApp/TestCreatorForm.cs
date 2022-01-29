using System;
using System.Windows.Forms;
using ClientServer;
using QuizLibrary;

namespace QuizApp
{
    public partial class TestCreatorForm : Form
    {
        private TestCreator creator;
        private Panel lastPanel;
        private Client client;

        public TestCreatorForm(Client _client)
        {
            InitializeComponent();

            client = _client;

            creator = new TestCreator(client.Nickname);
            creator.OnTestChanged += UpdateTestCreator;
            UpdateTestCreator();
        }

        public void UpdateTestCreator()
        {
            int autoScroll = 0;
            if (lastPanel != null)
                autoScroll = lastPanel.VerticalScroll.Value;

            panelTest.Controls.Clear();
            lastPanel = creator.Present();
            panelTest.Controls.Add(lastPanel);

            if (autoScroll < lastPanel.VerticalScroll.Minimum)
                lastPanel.VerticalScroll.Value = lastPanel.VerticalScroll.Minimum;
            else if (autoScroll > lastPanel.VerticalScroll.Maximum)
                lastPanel.VerticalScroll.Value = lastPanel.VerticalScroll.Maximum;
            else
                lastPanel.VerticalScroll.Value = autoScroll;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!creator.CheckTest())
                return;

            try
            {
                client.Send(new Request(RequestType.CreatingTest, client.Nickname, $"Create new test <{creator.CurrentTest.Name}>", creator.CurrentTest));
                Response response = client.Receive();

                if (!response.Result)
                {
                    MessageBox.Show("Тест не был загружен в базу данных");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }
            
            MessageBox.Show($"Тест успешно создан");
            creator.NewTest();
        }
    }
}
