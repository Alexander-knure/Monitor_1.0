using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Course_v1
{
    public partial class StatisticForm : MetroFramework.Forms.MetroForm
    {
        StatisticList sList;
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void ShowList(List<Statistic> rows)
        {
            foreach (var item in rows)
            {
                var viewItem = new ListViewItem(Convert.ToString(item.Time) + " ms");
                viewItem.SubItems.Add(Convert.ToString(item.CPU) + " %");
                viewItem.SubItems.Add(Convert.ToString(item.RAM) + " %");
                viewItem.SubItems.Add(Convert.ToString(item.TCPU) + " °C");
                viewItem.SubItems.Add(Convert.ToString(item.TMobo) + " °C");
                viewItem.SubItems.Add(Convert.ToString(item.Voltage) + " V");

                ListViewInfo.Items.Add(viewItem);
            }
        }

        private void UpdateList()
        {
            ListViewInfo.Items.Clear();

            var rows = new List<Statistic>();
            var timeList = sList.GetListTime();
            var cpuList = sList.GetListCPU();
            var ramList = sList.GetListRAM();
            var tcpuList = sList.GetListTCPU();
            var tmoboList = sList.GetListTMobo();
            var voltageList = sList.GetListVoltage();

            for (int i = 0; i < sList.GetCount(); i++)
            {
                var row = new Statistic();
                row.Time = timeList[i];
                row.CPU = cpuList[i];
                row.RAM = ramList[i];
                row.TCPU = tcpuList[i];
                row.TMobo = tmoboList[i];
                row.Voltage = voltageList[i];

                rows.Add(row);
            }

            ShowList(rows);
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            sList = new StatisticList();

            var dialog = new OpenFileDialog();
            dialog.Filter = "XML files|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                XmlSerializer formatter = new XmlSerializer(typeof(StatisticList));
                try
                {
                    using (var file = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        sList = (StatisticList)formatter.Deserialize(file);
                        MyMessageBox.ShowMessage("Statistics loaded successfully!", "Information", MessageBoxButtons.OK);
                        UpdateList();
                    }
                }
                catch
                {
                    MyMessageBox.ShowMessage("Information were not loaded \rsuccessfully! Please upload \ra file called \"Information\"", "Error!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
