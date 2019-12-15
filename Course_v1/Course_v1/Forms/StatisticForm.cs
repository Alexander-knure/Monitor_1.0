using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Management;

namespace Course_v1
{
    public partial class StatisticForm : MetroFramework.Forms.MetroForm
    {
        StatisticList sList;
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void ShowList(ref List<StatisticRow> rows)
        {
            foreach (var item in rows)
            {
                var viewItem = new ListViewItem(Convert.ToString(item.time) + " ms");
                viewItem.SubItems.Add(Convert.ToString(item.cpu) + " %");
                viewItem.SubItems.Add(Convert.ToString(item.ram) + " %");
                viewItem.SubItems.Add(Convert.ToString(item.tcpu) + " °C");
                viewItem.SubItems.Add(Convert.ToString(item.tmobo) + " °C");
                viewItem.SubItems.Add(Convert.ToString(item.voltage) + " V");

                ListViewInfo.Items.Add(viewItem);
            }
        }

        private void UpdateList()
        {
            ListViewInfo.Items.Clear();

            var rows = new List<StatisticRow>();
            var timeList = sList.GetListTime();
            var cpuList = sList.GetListCPU();
            var ramList = sList.GetListRAM();
            var tcpuList = sList.GetListTCPU();
            var tmoboList = sList.GetListTMobo();
            var voltageList = sList.GetListVoltage();

            for (int i = 0; i < sList.GetCount(); i++)
            {
                var row = new StatisticRow();
                row.time = timeList[i];
                row.cpu = cpuList[i];
                row.ram = ramList[i];
                row.tcpu = tcpuList[i];
                row.tmobo = tmoboList[i];
                row.voltage = voltageList[i];

                rows.Add(row);
            }

            ShowList(ref rows);
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            sList = new StatisticList();
            MyMessageBox.ShowMessage("Please upload a file called \r\"Statistic\", otherwise an error!", "Information;", MessageBoxButtons.OK);

            var dialog = new OpenFileDialog();
            dialog.Filter = "XML files|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        XmlSerializer formatter = new XmlSerializer(typeof(StatisticList));
                        try
                        {
                            using (var file = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                                sList = (StatisticList)formatter.Deserialize(file);
                                MyMessageBox.ShowMessage("Statistics loaded successfully!", "Information;", MessageBoxButtons.OK);
                                UpdateList();
                            }
                        }
                        catch
                        {
                            MyMessageBox.ShowMessage("Information were not loaded \rsuccessfully! Please upload \ra file called \"Information\"", "Error!", MessageBoxButtons.OK);
                        }
                        break;
                }
            }
        }
    }
    public class StatisticRow
    {
        public int time { get; set; }
        public float cpu { get; set; }
        public float ram{ get; set; }
        public float tcpu { get; set; }
        public double tmobo{ get; set; }
        public double voltage { get; set; }

        public StatisticRow()
        {
            time = 0;
            cpu = 0.0f;
            ram = 0.0f;
            tcpu = 0.0f;
            tmobo = 0.0d;
            voltage = 0.0d;
        }
    }
}
