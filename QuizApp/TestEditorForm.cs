using ClientServer;
using QuizLibrary;
using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class TestEditorForm : Form
    {
        private TestCreator editor;
        private Panel lastPanel;
        private Client client;

        public TestEditorForm(Client _client, Test testToEdit)
        {
            InitializeComponent();

            client = _client;

            editor = new TestCreator(client.Nickname, testToEdit);
            editor.OnTestChanged += UpdateTestEditor;
            UpdateTestEditor();
        }

        public void UpdateTestEditor()
        {
            int autoScroll = 0;
            if (lastPanel != null)
                autoScroll = lastPanel.VerticalScroll.Value;

            panelTest.Controls.Clear();
            lastPanel = editor.Present();
            panelTest.Controls.Add(lastPanel);

            if (autoScroll < lastPanel.VerticalScroll.Minimum)
                lastPanel.VerticalScroll.Value = lastPanel.VerticalScroll.Minimum;
            else if (autoScroll > lastPanel.VerticalScroll.Maximum)
                lastPanel.VerticalScroll.Value = lastPanel.VerticalScroll.Maximum;
            else
                lastPanel.VerticalScroll.Value = autoScroll;
        }

        private void labelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonalAreaForm parent = ParentForm as PersonalAreaForm;
            parent.OpenMenuTab(parent.myTestsForm);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!editor.CheckTest())
                return;

            try
            {
                client.Send(new Request(RequestType.EditingTest, client.Nickname, $"Edit test <{editor.CurrentTest.Name}>", editor.CurrentTest));
                Response response = client.Receive();

                if (!response.Result)
                {
                    MessageBox.Show("Не удалось отредактировать тест");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с сервером");
                return;
            }

            MessageBox.Show($"Тест успешно отредактирован");
        }
    }
}
