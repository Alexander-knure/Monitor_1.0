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
    public partial class InfoForm : MetroFramework.Forms.MetroForm
    {
        StatisticForm sForm;

        ComponentValueList cvList;
        ComponentValue cn;
        ComponentValue cv;
        public InfoForm()
        {
            InitializeComponent();
            cvList = new ComponentValueList();
            cn = new ComponentValue(); //0 id
            cv = new ComponentValue(); //1 id
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            var mosCPU = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
             foreach (ManagementObject mo in mosCPU.Get())
             {
                 cn.CPU_Name = "CPU name";
                 cv.CPU_Name = Convert.ToString(mo["Name"]);
                 ListViewItem item0 = new ListViewItem("CPU name");
                 item0.SubItems.Add(cv.CPU_Name);

                 cn.CPU_NCores = "Number of cores";
                 cv.CPU_NCores = Convert.ToString(mo["NumberOfCores"]);
                 ListViewItem item1 = new ListViewItem(cn.CPU_NCores);
                 item1.SubItems.Add(cv.CPU_NCores);

                cn.CPU_NThreads = "Number of threads";
                cv.CPU_NThreads = Convert.ToString(mo["ThreadCount"]);
                ListViewItem item2 = new ListViewItem(cn.CPU_NThreads);
                item2.SubItems.Add(cv.CPU_NThreads);

                cn.CPU_Architecture = "Architecture";
                cv.CPU_Architecture = Convert.ToString("x" + mo["AddressWidth"]);
                ListViewItem item3 = new ListViewItem(cn.CPU_Architecture);
                item3.SubItems.Add(cv.CPU_Architecture);

                cn.CPU_Clock = "CPU clock";
                cv.CPU_Clock = Convert.ToString(mo["MaxClockSpeed"] + " MHz");
                ListViewItem item4 = new ListViewItem(cn.CPU_Clock);
                item4.SubItems.Add(cv.CPU_Clock);

                cn.CPU_Socket = "Socket";
                cv.CPU_Socket = Convert.ToString(mo["SocketDesignation"]);
                ListViewItem item5 = new ListViewItem(cn.CPU_Socket);
                item5.SubItems.Add(cv.CPU_Socket);

                cn.CPU_Description = "CPU description";
                cv.CPU_Description = Convert.ToString(mo["Description"]);
                ListViewItem item6 = new ListViewItem(cn.CPU_Description);
                item6.SubItems.Add(cv.CPU_Description);

                cn.CPU_Manufacturer = "Manufacturer";
                cv.CPU_Manufacturer = Convert.ToString(mo["Manufacturer"]);
                ListViewItem item7 = new ListViewItem(cn.CPU_Manufacturer);
                item7.SubItems.Add(cv.CPU_Manufacturer);

                ListViewInfo.Items.Add(item0);
                ListViewInfo.Items.Add(item1);
                ListViewInfo.Items.Add(item2);
                ListViewInfo.Items.Add(item3);
                ListViewInfo.Items.Add(item4);
                ListViewInfo.Items.Add(item5);
                ListViewInfo.Items.Add(item6);
                ListViewInfo.Items.Add(item7);
            }

            var mosRAM = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject mo in mosRAM.Get())
            {
                cn.RAM_BankLabel = "BankLabel";
                cv.RAM_BankLabel = Convert.ToString(mo["BankLabel"]);
                ListViewItem item0 = new ListViewItem(cn.RAM_BankLabel);
                item0.SubItems.Add(cv.RAM_BankLabel);


                var cpctRAM = Math.Round(System.Convert.ToDouble(mo["Capacity"]) / 1024 / 1024 / 1024, 2);
                cn.RAM_Capacity = "RAM capacity";
                cv.RAM_Capacity = Convert.ToString(cpctRAM + " Gb");
                ListViewItem item1 = new ListViewItem(cn.RAM_Capacity);
                item1.SubItems.Add(cv.RAM_Capacity);

                cn.RAM_Clock = "Speed";
                cv.RAM_Clock = Convert.ToString(mo["Speed"] + " MHz");
                ListViewItem item2 = new ListViewItem(cn.RAM_Clock);
                item2.SubItems.Add(cv.RAM_Clock);

                ListViewInfo.Items.Add(item0);
                ListViewInfo.Items.Add(item1);
                ListViewInfo.Items.Add(item2);
            }

            var mosMOBO = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject mo in mosMOBO.Get())
            {
                cn.MOBO_Name = "Motherboard";
                cv.MOBO_Name = Convert.ToString(mo["Product"]);
                ListViewItem item0 = new ListViewItem(cn.MOBO_Name);
                item0.SubItems.Add(cv.MOBO_Name);

                cn.MOBO_Caption = "Caption motherboard";
                cv.MOBO_Caption = Convert.ToString(mo["Caption"]);
                ListViewItem item1 = new ListViewItem(cn.MOBO_Caption);
                item1.SubItems.Add(cv.MOBO_Caption);

                cn.MOBO_Manufacturer = "Motherboard manufacturer";
                cv.MOBO_Manufacturer = Convert.ToString(mo["Manufacturer"]);
                ListViewItem item2 = new ListViewItem(cn.MOBO_Manufacturer);
                item2.SubItems.Add(cv.MOBO_Manufacturer);

                ListViewInfo.Items.Add(item0);
                ListViewInfo.Items.Add(item1);
                ListViewInfo.Items.Add(item2);
            }

            var mosGPU = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject mo in mosGPU.Get())
            {
                cn.GPU_Name = "GPU name";
                cv.GPU_Name = Convert.ToString(mo["VideoProcessor"]);
                ListViewItem item0 = new ListViewItem(cn.GPU_Name);
                item0.SubItems.Add(cv.GPU_Name);

                cn.GPU_Model = "GPU model";
                cv.GPU_Model = Convert.ToString(mo["Caption"]);
                ListViewItem item1 = new ListViewItem(cn.GPU_Model);
                item1.SubItems.Add(cv.GPU_Model);
                
                var cpctVRAM = Math.Round(System.Convert.ToDouble(mo["AdapterRAM"]) / 1024 / 1024, 2);
                cn.GPU_Capacity = "GPU capacity";
                cv.GPU_Capacity = Convert.ToString(cpctVRAM + " Mb");
                ListViewItem item2 = new ListViewItem(cn.GPU_Capacity);
                item2.SubItems.Add(cv.GPU_Capacity);

                ListViewInfo.Items.Add(item0);
                ListViewInfo.Items.Add(item1);
                ListViewInfo.Items.Add(item2);
            }

            var mosOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject mo in mosOS.Get())
            {
                cn.OS_Caption = "OS caption";
                cv.OS_Caption = Convert.ToString(mo["Caption"]);
                ListViewItem item0 = new ListViewItem(cn.OS_Caption);
                item0.SubItems.Add(cv.OS_Caption);

                string c = mo["Caption"].ToString();
                string k = mo["Name"].ToString();
                cn.OS_Location = "OS location";
                cv.OS_Location = k.Remove(0, c.Length + 1);
                ListViewItem item1 = new ListViewItem(cn.OS_Location);
                item1.SubItems.Add(cv.OS_Location);

                cn.OS_BuildNumber = "Build number";
                cv.OS_BuildNumber = Convert.ToString(mo["BuildNumber"]);
                ListViewItem item2 = new ListViewItem(cn.OS_BuildNumber);
                item2.SubItems.Add(cv.OS_BuildNumber);

                cn.OS_Version = "Version";
                cv.OS_Version = Convert.ToString(mo["Version"]);
                ListViewItem item3 = new ListViewItem(cn.OS_Version);
                item3.SubItems.Add(cv.OS_Version);

                var cpctFPM = Math.Round(System.Convert.ToDouble(mo["FreePhysicalMemory"]) / 1024 / 1024, 2);
                cn.OS_FPM = "Free physical memory";
                cv.OS_FPM = Convert.ToString(cpctFPM + " Gb");
                ListViewItem item4 = new ListViewItem(cn.OS_FPM);
                item4.SubItems.Add(cv.OS_FPM);
                
                var cpctFVM = Math.Round(System.Convert.ToDouble(mo["FreeVirtualMemory"]) / 1024 / 1024, 2);
                cn.OS_FVM = "Free virtual memory";
                cv.OS_FVM = Convert.ToString(cpctFVM + " Gb");
                ListViewItem item5= new ListViewItem(cn.OS_FVM);
                item5.SubItems.Add(cv.OS_FVM);

                cn.OS_SerialNumber = "OS Serial number";
                cv.OS_SerialNumber = Convert.ToString(mo["SerialNumber"]);
                ListViewItem item6 = new ListViewItem(cn.OS_SerialNumber);
                item6.SubItems.Add(cv.OS_SerialNumber);

                cn.OS_SystemDrive = "System drive";
                cv.OS_SystemDrive = Convert.ToString(mo["SystemDrive"]);
                ListViewItem item7 = new ListViewItem(cn.OS_SystemDrive);
                item7.SubItems.Add(cv.OS_SystemDrive);

                ListViewInfo.Items.Add(item0);
                ListViewInfo.Items.Add(item1);
                ListViewInfo.Items.Add(item2);
                ListViewInfo.Items.Add(item3);
                ListViewInfo.Items.Add(item4);
                ListViewInfo.Items.Add(item5);
                ListViewInfo.Items.Add(item6);
                ListViewInfo.Items.Add(item7);
            }
            cvList.Add(cn, cv);
        }

        private void ShowList(ref List<Row> rows)
        {
            foreach (var item in rows)
            {
                var viewItem = new ListViewItem(item.ComponentName);
                viewItem.SubItems.Add(item.ComponentValue);

                ListViewInfo.Items.Add(viewItem);
            }
        }

        private void UpdateList()
        {
            ListViewInfo.Items.Clear();

            var rows = new List<Row>();
            var nameList = cvList.GetListName();
            var valueList = cvList.GetListValue();

            for(int i = 0; i < cvList.GetCount(); i++)
            {
                var row = new Row();
                row.ComponentName = nameList[i];
                row.ComponentValue = valueList[i];
                rows.Add(row);
            }

            ShowList(ref rows);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ComponentValue));
            using (FileStream fs = new FileStream("Information.xml", FileMode.Create))
            {
                formatter.Serialize(fs, cv);

                MyMessageBox.ShowMessage("Information saved successfully!", "Information", MessageBoxButtons.OK);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowMessage("Please upload a file called \r\"Information\", otherwise an error!", "Information;", MessageBoxButtons.OK);
            var dialog = new OpenFileDialog();
            dialog.Filter = "XML files|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        XmlSerializer formatter = new XmlSerializer(typeof(ComponentValue));
                        try
                        {
                            using (var file = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                            {

                                cv.Clear();
                                cv = (ComponentValue)formatter.Deserialize(file);
                                MyMessageBox.ShowMessage("Information loaded successfully!", "Information", MessageBoxButtons.OK);
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

        private void btLoadStatistic_Click(object sender, EventArgs e)
        {
            if (sForm == null || sForm.IsDisposed)
            {
                sForm = new StatisticForm();
                sForm.Show();
            }
        }
    }
}
