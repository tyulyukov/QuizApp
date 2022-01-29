using System;
using System.IO;
using System.Text;

namespace QuizServer
{
    public class Logs
    {
        public readonly String LogsFileName = "Logs.txt";

        private StringBuilder logsText = new StringBuilder();

        public void Record(String log) => logsText.AppendLine(log);

        public void Save()
        {
            if (String.IsNullOrWhiteSpace(logsText.ToString()))
                return;

            using (StreamWriter writer = new StreamWriter(LogsFileName, true))
                writer.Write(logsText.ToString());

            logsText.Clear();
        }
    }
}
