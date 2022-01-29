using System.Windows.Forms;

namespace WindowControllers
{
    public class WindowController
    {
        public bool Normalized { get; private set; }

        private Form CurrentForm;

        public WindowController(Form currentForm)
        {
            CurrentForm = currentForm;
            Normalized = true;
        }

        public void Maximize()
        {
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.WindowState = FormWindowState.Maximized;
            Normalized = false;
        }

        public void Normalize()
        {
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.WindowState = FormWindowState.Normal;
            Normalized = true;
        }

        public void Minimize()
        {
            CurrentForm.WindowState = FormWindowState.Minimized;
        }

        public void Close()
        {
            CurrentForm.Close();
        }
    }
}
