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

        Limit limit;
        //if true - absolute, else - percentage
        private bool flagCPU;
        private bool flagRAM;
        private bool flagTCPU;
        private bool flagTMobo;
        private bool flagVoltage;

        public ThresholdForm()
        {
            InitializeComponent();
        }

        private void Threshold_Load(object sender, EventArgs e)
        {
            limit = new Limit();
            flagCPU = false;
            flagRAM = false;
            flagTCPU = false;
            flagTMobo = false;
            flagVoltage = false;
        }

        private void btSCPU_Click(object sender, EventArgs e)
        {
            if (flagCPU == false)
            {
                limit.lCPU = float.Parse(tbCPU.Text);
            }
            else
            {
                limit.lCPU = float.Parse(tbCPU.Text) % 101;
            }
        }

        private void btSRAM_Click(object sender, EventArgs e)
        {
            if (flagRAM == false)
            {
                limit.lRAM = float.Parse(tbRAM.Text);
            }
            else
            {
                limit.lRAM = float.Parse(tbRAM.Text) % 101;
            }
        }

        private void btSTCPU_Click(object sender, EventArgs e)
        {
            if (flagTCPU == false)
            {
                limit.lTCPU = float.Parse(tbTCPU.Text);
            }
            else
            {
                limit.lTCPU = float.Parse(tbTCPU.Text) % 101;
            }
        }

        private void btSMOBO_Click(object sender, EventArgs e)
        {
            if (flagTMobo == false)
            {
                limit.lTMobo = double.Parse(tbTMOBO.Text);
            }
            else
            {
                limit.lTMobo = double.Parse(tbTMOBO.Text) % 101;
            }
        }

        private void btSVOLTAGE_Click(object sender, EventArgs e)
        {
            if (flagVoltage == false)
            {
                limit.lVoltage = float.Parse(tbVOLTAGE.Text);
            }
            else
            {
                limit.lVoltage = float.Parse(tbVOLTAGE.Text) % 101;
            }
        }

        private void rbtA_CPU_CheckedChanged(object sender, EventArgs e)
        {
            flagCPU = false;
        }

        private void rbtP_CPU_CheckedChanged(object sender, EventArgs e)
        {
            flagCPU = true;
        }

        private void rbtA_RAM_CheckedChanged(object sender, EventArgs e)
        {
            flagRAM = false;
        }

        private void rbtP_RAM_CheckedChanged(object sender, EventArgs e)
        {
            flagRAM = true;
        }

        private void rbtA_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            flagTCPU = false;
        }

        private void rbtP_TCPU_CheckedChanged(object sender, EventArgs e)
        {
            flagTCPU = true;
        }

        private void rbtA_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            flagTMobo = false;
        }

        private void rbtP_TMOBO_CheckedChanged(object sender, EventArgs e)
        {
            flagTMobo = true;
        }

        private void rbtA_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            flagVoltage = false;
        }

        private void rbtP_VOLTAGE_CheckedChanged(object sender, EventArgs e)
        {
            flagVoltage = true;
        }
    }
}
