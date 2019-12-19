using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Course_v1
{
    public partial class ThresholdForm : MetroFramework.Forms.MetroForm
    {
        bool flag;

        public ThresholdForm()
        {
            InitializeComponent();
        }

        private void Threshold_Load(object sender, EventArgs e)
        {
            Limit.Notify += ErrorMessage;
            this.rbtP_CPU_CheckedChanged(sender, e);
            this.rbtP_RAM_CheckedChanged(sender, e);
            this.rbtA_TCPU_CheckedChanged(sender, e);
            this.rbtA_TMOBO_CheckedChanged(sender, e);
            this.rbtA_VOLTAGE_CheckedChanged(sender, e);

            //Limit.isAbsoluteCPU = false;
            //Limit.isAbsoluteRAM = false;
            //Limit.isAbsoluteTCPU = true;
            //Limit.isAbsoluteTMobo = true;
            //Limit.isAbsoluteVoltage = true;
        }

        private void ErrorMessage(string s)
        {
            MyMessageBox.ShowMessage(s,
            "Message error",
            MessageBoxButtons.OK);
        }
        private void btSTimer_Click(object sender, EventArgs e)
        {
            int resInt = 0;
            float res = 0.0f;
            decimal resDec = 0.0M;

            flag = false;

            if (tbTimer.Text.Length > 0 && int.TryParse(tbTimer.Text.ToString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out resInt))
            {
                Limit.lTime = resInt;
                Limit.Time = resInt;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct timer!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }

            if (tbCPU.Text.Length > 0 && float.TryParse(tbCPU.Text.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                Limit.lCPU = res;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct CPU load!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }

            if (tbRAM.Text.Length > 0 && float.TryParse(tbRAM.Text.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                Limit.lRAM = res;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct RAM load!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }

            if (tbTCPU.Text.Length > 0 && float.TryParse(tbTCPU.Text.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                Limit.lTCPU = res;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct CPU temperature!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }

            if (tbTMOBO.Text.Length > 0 && float.TryParse(tbTMOBO.Text.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                Limit.lTMobo = res;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct motherboard \rtemperature!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }

            if (tbVOLTAGE.Text.Length > 0 && float.TryParse(tbVOLTAGE.Text.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                Limit.lVoltage = resDec;
                flag = true;
            }
            else
            {
                MyMessageBox.ShowMessage("Please, enter correct voltage!", "Warning", MessageBoxButtons.OK);
                flag = false;
            }
        }

        private void rbtA_CPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteCPU = true;
        }

        private void rbtP_CPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteCPU = false;
        }

        private void rbtA_RAM_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteRAM = true;
        }

        private void rbtP_RAM_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteRAM = false;
        }

        private void rbtA_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTCPU = true;
        }

        private void rbtP_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTCPU = false;
        }

        private void rbtA_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTMobo = true;
        }

        private void rbtP_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTMobo = false;
        }

        private void rbtA_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteVoltage = true;
        }

        private void rbtP_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteVoltage = false;
        }

        private void ThresholdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Limit.isAlive = flag;
        }
    }
}
