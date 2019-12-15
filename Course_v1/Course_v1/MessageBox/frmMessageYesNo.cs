using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_v1.MessageBox
{
    public partial class frmMessageYesNo : MetroFramework.Forms.MetroForm
    {
        public frmMessageYesNo()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public string Message
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
    }
}
