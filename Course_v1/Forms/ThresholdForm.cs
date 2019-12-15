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
    public partial class ThresholdForm : MetroFramework.Forms.MetroForm
    {
        //if true - absolute, else - percentage

        public ThresholdForm()
        {
            InitializeComponent();
        }

        private void Threshold_Load(object sender, EventArgs e)
        {
        }

        private void ErrorMessage(string s)
        {
            MyMessageBox.ShowMessage(s,
            "Message error",
            MessageBoxButtons.OK);
        }
        private void btSTimer_Click(object sender, EventArgs e)
        {
            if (tbTimer.Text.Length > 0)
            {
              Limit.lTime = int.Parse(tbTimer.Text.ToString());
              Limit.Time = Limit.lTime;
            }
            if (tbCPU.Text.Length > 0)
            {
                if (Limit.isAbsoluteCPU)
                {
                    Limit.lCPU = float.Parse(tbCPU.Text.ToString());
                }
                else
                {
                    Limit.lCPU = float.Parse(tbCPU.Text) % 101;
                }
            }
            if (tbRAM.Text.Length > 0)
            {
                if (Limit.isAbsoluteRAM)
                {
                    Limit.lRAM = float.Parse(tbRAM.Text.ToString());
                }
                else
                {
                    Limit.lRAM = float.Parse(tbRAM.Text) % 101;
                }
            }
            if (tbTCPU.Text.Length > 0)
            {
                if (Limit.isAbsoluteTCPU)
                {
                    Limit.lTCPU = float.Parse(tbTCPU.Text.ToString());
                }
                else
                {
                    Limit.lTCPU = float.Parse(tbTCPU.Text.ToString()) % 101;
                }
            }
            if (tbTMOBO.Text.Length > 0)
            {
                if (Limit.isAbsoluteTMobo)
                {
                    Limit.lTMobo = double.Parse(tbTMOBO.Text.ToString());
                }
                else
                {
                    Limit.lTMobo = double.Parse(tbTMOBO.Text.ToString()) % 101;
                }
            }
            if (tbVOLTAGE.Text.Length > 0)
            {
                if (Limit.isAbsoluteVoltage)
                {
                    Limit.lVoltage = float.Parse(tbVOLTAGE.Text.ToString());
                }
                else
                {
                    Limit.lVoltage = float.Parse(tbVOLTAGE.Text.ToString()) % 101;
                }
            }
        }

        private void btSCPU_Click(object sender, EventArgs e)
        {
          
        }

        private void btSRAM_Click(object sender, EventArgs e)
        {
         
        }

        private void btSTCPU_Click(object sender, EventArgs e)
        {
         
        }

        private void btSMOBO_Click(object sender, EventArgs e)
        {
         
        }

        private void btSVOLTAGE_Click(object sender, EventArgs e)
        {
          
        }

        private void rbtA_CPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteCPU = false;
        }

        private void rbtP_CPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteCPU = true;
        }

        private void rbtA_RAM_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteRAM = false;
        }

        private void rbtP_RAM_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteRAM = true;
        }

        private void rbtA_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTCPU = false;
        }

        private void rbtP_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTCPU = true;
        }

        private void rbtA_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTMobo = false;
        }

        private void rbtP_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteTMobo = true;
        }

        private void rbtA_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteVoltage = false;
        }

        private void rbtP_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            Limit.isAbsoluteVoltage = true;
        }
    }
}
