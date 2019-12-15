using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Management;

namespace Course_v1
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        StatisticList statList;

        ThresholdForm tForm;
        InfoForm iForm;

        static int timer;

        ManagementObjectSearcher searcherTemp = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        double temperatureCPU = 0.0d;
        
        //ManagementObjectSearcher searcherVoltage = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_Battery");
        ManagementObjectSearcher searcherVoltage = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_Processor ");
        double voltage = 0.0d;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statList = new StatisticList();

            timer = 0;
        }

        private void cTimer_Tick(object sender, EventArgs e)
        {
            Statistic s = new Statistic();
        
            try
            {
                s.Time = timer * cTimer.Interval;
                timer++;

                s.CPU = cCPU.NextValue();
                s.RAM = cRAM.NextValue();
                s.TCPU = сTCPU.NextValue() - 273;


                foreach (var mo in searcherTemp.Get())
                {
                    temperatureCPU = Convert.ToDouble(mo["CurrentTemperature"].ToString());
                    temperatureCPU = (temperatureCPU - 2732) / 10.0d;
                }
                s.TMobo = temperatureCPU - 5;
                //foreach (var mo in searcherVoltage.Get())
                //{
                //        // voltage = Convert.ToDouble(mo["DesignVoltage"].ToString()) / 1000;
                //        voltage = Convert.ToDouble(mo["CurrentVoltage"].ToString()) / 1000;
                //    }
                s.Voltage = voltage;


                if (Limit.IsExist() == true)
                {
                    if ((Limit.lCPU >= s.CPU && Limit.lRAM >= s.RAM && Limit.lTCPU >= s.TCPU && 
                        Limit.lTMobo >= s.TMobo && Limit.lVoltage >= s.Voltage)&& Limit.Time <= 0)
                    {
                        MyMessageBox.ShowMessage("Threshold is load!", "Warning;", MessageBoxButtons.OK);
                        Limit.Clear();
                    }
                    if((Limit.lCPU >= s.CPU && Limit.lRAM >= s.RAM && Limit.lTCPU >= s.TCPU &&
                        Limit.lTMobo >= s.TMobo && Limit.lVoltage >= s.Voltage) && Limit.Time > 0)
                    {
                        Limit.Time -= cTimer.Interval;
                       MyMessageBox.ShowMessage("Clear!", "Warning;", MessageBoxButtons.OK);
                    }
                    if (Limit.lCPU < s.CPU || Limit.lRAM < s.RAM || Limit.lTCPU < s.TCPU ||
                        Limit.lTMobo < s.TMobo || Limit.lVoltage < s.Voltage)
                    {

                        Limit.Time = Limit.lTime;
                    }
                }

                pbCPU.Value = (int)s.CPU;
                lbPCPU.Text = string.Format("{0 : 0.00}%", s.CPU);
                ChangeStyle("pbCPU", (int)s.CPU);

                pbRAM.Value = (int)s.RAM;
                lbPRAM.Text = string.Format("{0 : 0.00}%", s.RAM);
                ChangeStyle("pbRAM", (int)s.RAM);

                pbTempCPU.Value = (int)s.TCPU;
                lbPTempCPU.Text = string.Format(" {0} °C", s.TCPU);
                ChangeStyle("pbTempCPU", (int)s.TCPU);

                pbTempMOBO.Value = (int)s.TMobo;
                lbPTempMOBO.Text = string.Format(" {0} °C", s.TMobo);
                ChangeStyle("pbTempMOBO", (int)s.TMobo);

                pbVoltage.Value = (int)s.Voltage;
                lbPVoltage.Text = string.Format("{0 : 0.00} V", s.Voltage);
                ChangeStyle("pbVoltage", (int)s.Voltage);


                MainChart.Series["CPU"].Points.AddY(s.CPU);
                MainChart.Series["RAM"].Points.AddY(s.RAM);
                MainChart.Series["t CPU"].Points.AddY(s.TCPU);
                MainChart.Series["t motherboard"].Points.AddY(s.TMobo);
                MainChart.Series["Voltage"].Points.AddY(s.Voltage);

                statList.Add(s);
            }
            catch (Exception)
            {
                MyMessageBox.ShowMessage("Error in timer!", "Warning", MessageBoxButtons.OK);
            }

        }

        void ChangeStyle(string name, int value)
        {
            switch (name)
            {
                case "pbCPU":
                    {
                        if (value < 20)
                            pbCPU.Style = MetroFramework.MetroColorStyle.Green;
                        else if (value > 20 && value < 40)
                            pbCPU.Style = MetroFramework.MetroColorStyle.Lime;
                        else if (value >= 40 && value < 60)
                            pbCPU.Style = MetroFramework.MetroColorStyle.Yellow;
                        else if (value >= 60 && value < 80)
                            pbCPU.Style = MetroFramework.MetroColorStyle.Orange;
                        else if (value >= 80 && value < 100)
                            pbCPU.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;
                case "pbRAM":
                    {
                        if (value < 20)
                            pbRAM.Style = MetroFramework.MetroColorStyle.Green;
                        else if (value > 20 && value < 40)
                            pbRAM.Style = MetroFramework.MetroColorStyle.Lime;
                        else if (value >= 40 && value < 60)
                            pbRAM.Style = MetroFramework.MetroColorStyle.Yellow;
                        else if (value >= 60 && value < 80)
                            pbRAM.Style = MetroFramework.MetroColorStyle.Orange;
                        else if (value >= 80 && value < 100)
                            pbRAM.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;
                case "pbTempCPU":
                    {
                        if (value < 20)
                            pbTempCPU.Style = MetroFramework.MetroColorStyle.Green;
                        else if (value > 20 && value < 40)
                            pbTempCPU.Style = MetroFramework.MetroColorStyle.Lime;
                        else if (value >= 40 && value < 60)
                            pbTempCPU.Style = MetroFramework.MetroColorStyle.Yellow;
                        else if (value >= 60 && value < 80)
                            pbTempCPU.Style = MetroFramework.MetroColorStyle.Orange;
                        else if (value >= 80 && value < 100)
                            pbTempCPU.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;
                case "pbTempMOBO":
                    {
                        if (value < 20)
                            pbTempMOBO.Style = MetroFramework.MetroColorStyle.Green;
                        else if (value > 20 && value < 40)
                            pbTempMOBO.Style = MetroFramework.MetroColorStyle.Lime;
                        else if (value >= 40 && value < 60)
                            pbTempMOBO.Style = MetroFramework.MetroColorStyle.Yellow;
                        else if (value >= 60 && value < 80)
                            pbTempMOBO.Style = MetroFramework.MetroColorStyle.Orange;
                        else if (value >= 80 && value < 100)
                            pbTempMOBO.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;
                case "pbVoltage":
                    {
                        if (value < 20)
                            pbVoltage.Style = MetroFramework.MetroColorStyle.Green;
                        else if (value > 20 && value < 40)
                            pbVoltage.Style = MetroFramework.MetroColorStyle.Lime;
                        else if (value >= 40 && value < 60)
                            pbVoltage.Style = MetroFramework.MetroColorStyle.Yellow;
                        else if (value >= 60 && value < 80)
                            pbVoltage.Style = MetroFramework.MetroColorStyle.Orange;
                        else if (value >= 80 && value < 100)
                            pbVoltage.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;

                default:
                    break;
            }

        }

        private void btSetThreshold_Click(object sender, EventArgs e)
        {
            if (tForm == null || tForm.IsDisposed)
            {
                tForm = new ThresholdForm();
                tForm.Show();
            }
        }

        private void btMoreInfo_Click(object sender, EventArgs e)
        {
            if (iForm == null || iForm.IsDisposed)
            {
                iForm = new InfoForm();
                iForm.Show();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(StatisticList));
            
           // if (Directory.Exists("Log")) { 
                using (FileStream fs = new FileStream("Statistic.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, statList);

                    MyMessageBox.ShowMessage("Statistics saved successfully!", "Information;", MessageBoxButtons.OK);
                }
          //  }
          //  else
          //  {
          //      MyMessageBox.ShowMessage("Statistics were not saved \rsuccessfully!", "Warning;", MessageBoxButtons.OK);
          //  }
        }

        private void btTimer_Click(object sender, EventArgs e)
        {
            cTimer.Enabled = !cTimer.Enabled;
            if (cTimer.Enabled == true )
                btTimer.Text = string.Format("Stop");
            else
                btTimer.Text = string.Format("Play");
            
            // MyMessageBox.ShowMessage("You stop timer and monitor!", "Warning;", MessageBoxButtons.YesNo);
        }

        
    }
}
