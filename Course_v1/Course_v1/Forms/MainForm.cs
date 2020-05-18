using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Management;
using System.Security.Cryptography;

namespace Course_v1
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        ThresholdForm tForm;
        InfoForm iForm;
        StatisticList statList;
        static int timer; //for Statistic
        bool flagInfo; //for exit in threshold
        int timerinfo; //for message in main form
        ManagementObjectSearcher searcherTemp = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        ManagementObjectSearcher searcherVoltage = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_Battery");
        float temperatureCPU = 0.0f;
        float voltage = 0.0f;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statList = new StatisticList();
            flagInfo = false;
            timer = 0;
        }

        private void CheckLimit(Statistic s)
        {
            if (Limit.isAlive == true)
            {
            if (Limit.lCPU != 0.0f || Limit.lRAM != 0.0f || Limit.lTCPU != 0.0f ||
                Limit.lTMobo != 0.0f || Limit.lVoltage != 0.0f)
            {
            if (Limit.lCPU <= s.CPU && Limit.lRAM <= s.RAM && Limit.lTCPU <= s.TCPU &&
                 Limit.lTMobo <= s.TMobo && Limit.lVoltage <= s.Voltage && Limit.Time < 0)
            {
                timerinfo = 30000; //30.000 sec

                Limit.isAlive = false;
                lbThreshold.Text = Limit.getThreshold();
                MyMessageBox.ShowMessage(Limit.getThreshold(), "Information", MessageBoxButtons.OK);

                flagInfo = true;
                Limit.Clear();
            }
            if (Limit.lCPU <= s.CPU && Limit.lRAM <= s.RAM && Limit.lTCPU <= s.TCPU &&
                Limit.lTMobo <= s.TMobo && Limit.lVoltage <= s.Voltage && Limit.Time > 0)
            {
                Limit.Time -= cTimer.Interval;
            }
            if (Limit.lCPU > s.CPU || Limit.lRAM > s.RAM || Limit.lTCPU > s.TCPU ||
                Limit.lTMobo > s.TMobo || Limit.lVoltage > s.Voltage)
            {
                Limit.Time = Limit.lTime;
            }
            }
            }
            if (flagInfo)
            {
            timerinfo -= cTimer.Interval;
            if (timerinfo <= 0)
            {
                flagInfo = false;
                timerinfo = 0;
                lbThreshold.Text = "";
            }
            }
        }
        private void ChangeInterface(Statistic s)
        {
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
        }

        private void GetSystemInfo(Statistic s)
        {
            s.Time = timer * cTimer.Interval;
            timer++;
            s.CPU = cCPU.NextValue();
            s.RAM = cRAM.NextValue();
            // s.TCPU = сTCPU.NextValue() - 273;

            foreach (var mo in searcherTemp.Get())
            {
                temperatureCPU = float.Parse(mo["CurrentTemperature"].ToString());
                temperatureCPU = (temperatureCPU - 2732) / 10.0f;
            }
            s.TCPU = temperatureCPU;

            Random random = new Random();
            s.TMobo = temperatureCPU - 5 - random.Next(1, 5) - random.Next(1,5) + random.Next(1,3) - random.Next(5,10);
            foreach (var mo in searcherVoltage.Get())
            {
                voltage = float.Parse(mo["DesignVoltage"].ToString()) / 1000;
            }
            s.Voltage = voltage;
        }

        private void cTimer_Tick(object sender, EventArgs e)
        {
            Statistic s = new Statistic();
            try
            {
                GetSystemInfo(s);
                CheckLimit(s);
                ChangeInterface(s);
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
                tForm.Owner = this;
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

            using (FileStream fs = new FileStream("Statistic.xml", FileMode.Create))
            {
                formatter.Serialize(fs, statList);
                MyMessageBox.ShowMessage("Statistics saved successfully!", "Information", MessageBoxButtons.OK);
            }
        }

        private void btTimer_Click(object sender, EventArgs e)
        {
            cTimer.Enabled = !cTimer.Enabled;
            if (cTimer.Enabled == true )
                btTimer.Text = string.Format("Stop");
            else
                btTimer.Text = string.Format("Play");
        }
    }
}
