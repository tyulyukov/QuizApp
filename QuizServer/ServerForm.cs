using System;
using System.Threading;
using System.Windows.Forms;
using ClientServer;

namespace QuizServer
{
    public partial class ServerForm : Form
    {
        private Server server;
        private SynchronizationContext uiSync;
        private Logs logs;

        public ServerForm()
        {
            InitializeComponent();

            uiSync = SynchronizationContext.Current;

            logs = new Logs();

            server = new Server("0.0.0.0", 1000);
            server.ShowMessage += Server_ShowMessage;
        }

        private void Server_ShowMessage(string message) => uiSync.Send(ShowMessage, message);

        private void ShowMessage(object state) 
        {
            listBoxLogs.Items.Add($"{DateTime.Now.ToShortTimeString()} | " + state);
            logs.Record($"{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")} | " + state);
        }

        private void buttonStart_Click(object sender, EventArgs e) 
        { 
            buttonStart.Enabled = false;

            var thread = new Thread(() => 
            {
                server.Start();
                uiSync.Send((object state) => buttonStart.Enabled = (bool)state, true);
                timerLogs.Stop();
            });
            thread.IsBackground = true;
            thread.Start();
            timerLogs.Start();
        }

        private void numericUpDownDelay_ValueChanged(object sender, EventArgs e) => timerLogs.Interval = (int)numericUpDownDelay.Value * 1000;

        private void timerLogs_Tick(object sender, EventArgs e) => logs.Save();

        private void ServerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && checkBoxHideInTray.Checked)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
                Hide();
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
            Show();
            BringToFront();
        }
    }
}
