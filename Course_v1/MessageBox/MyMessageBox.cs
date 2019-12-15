using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_v1
{
    public partial class MyMessageBox : MetroFramework.Forms.MetroForm
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
               case System.Windows.Forms.MessageBoxButtons.OK:
                    using (var  msInfo= new MessageBox.frmMessageInfo())
                    {
                        msInfo.Text = caption;
                        msInfo.Message = message;

                        dlgResult = msInfo.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (var msInfo = new MessageBox.frmMessageYesNo())
                    {
                        msInfo.Text = caption;
                        msInfo.Message = message;

                        dlgResult = msInfo.ShowDialog();
                    }
                    break;
            }


            return dlgResult;
        }



    }
}
