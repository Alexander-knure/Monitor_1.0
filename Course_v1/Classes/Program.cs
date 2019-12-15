using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Course_v1
{
    static class Program
    {

        //////////////////////////////////////////////////
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // [STAThread]
        // static void Main()
        // {
        //
        //     using (Mutex myLock = new Mutex(false, "Course_v1"))
        //     {
        //         Application.EnableVisualStyles();
        //
        //         Application.SetCompatibleTextRenderingDefault(false);
        //
        //         if (myLock.WaitOne(3000, false))
        //         {
        //             Application.Run(new MainForm());
        //         }
        //         else
        //         {
        //             MyMessageBox.ShowMessage("A program is running!", "Warning!", MessageBoxButtons.OK);
        //         }
        //     }
        // }

        [STAThread]
        static void Main()
        {

                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);
      
                Application.Run(new MainForm());
        }
    }
}
