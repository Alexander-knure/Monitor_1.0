using System;
using System.Windows.Forms;

namespace Course_v1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
        }
    }
}
