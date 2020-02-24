using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_v1
{
    public class ComponentValue
    {
        //CPU
        public string CPU_Name { get; set; }
        public string CPU_NCores { get; set; }
        public string CPU_NThreads { get; set; }
        public string CPU_Architecture { get; set; }
        public string CPU_Clock { get; set; }
        public string CPU_Socket { get; set; }
        public string CPU_Description { get; set; }
        public string CPU_Manufacturer { get; set; }
        //RAM
        public string RAM_BankLabel { get; set; }
        public string RAM_Capacity { get; set; }
        public string RAM_Clock { get; set; }
        //MOBO
        public string MOBO_Name { get; set; }
        public string MOBO_Caption { get; set; }
        public string MOBO_Manufacturer { get; set; }
        //GPU
        public string GPU_Name { get; set; }
        public string GPU_Model { get; set; }
        public string GPU_Capacity { get; set; }
        //OS
        public string OS_Caption { get; set; }
        public string OS_Location { get; set; }
        public string OS_BuildNumber { get; set; }
        public string OS_Version { get; set; }
        public string OS_FPM { get; set; }
        public string OS_FVM { get; set; }
        public string OS_SerialNumber { get; set; }
        public string OS_SystemDrive { get; set; }

        public ComponentValue()
        {
        }

        public void Clear()
        {
            this.CPU_Name = "";
            this.CPU_NCores = "";
            this.CPU_NThreads = "";
            this.CPU_Architecture = "";
            this.CPU_Clock = "";
            this.CPU_Clock = "";
            this.CPU_Description = "";
            this.CPU_Description = "";

            this.RAM_BankLabel = "";
            this.RAM_Capacity = "";
            this.RAM_Clock = "";

            this.MOBO_Name = "";
            this.MOBO_Caption = "";
            this.MOBO_Manufacturer = "";

            this.GPU_Name = "";
            this.GPU_Capacity = "";
            this.GPU_Model = "";

            this.OS_Caption = "";
            this.OS_Location = "";
            this.OS_BuildNumber = "";
            this.OS_Version = "";
            this.OS_FPM = "";
            this.OS_FVM = "";
            this.OS_SerialNumber = "";
            this.OS_SystemDrive = "";
        }
    }

    [Serializable]
    public class ComponentValueList
    {
        public  Dictionary<string, string> cvList;

        public ComponentValueList()
        {
            cvList = new Dictionary<string, string>();
        }

        public void Add(ComponentValue cn, ComponentValue cv)
        {
            cvList[cn.CPU_Name] = cv.CPU_Name;
            cvList[cn.CPU_NCores] = cv.CPU_NCores;
            cvList[cn.CPU_NThreads] = cv.CPU_NThreads;
            cvList[cn.CPU_Architecture] = cv.CPU_Architecture;
            cvList[cn.CPU_Clock] = cv.CPU_Clock;
            cvList[cn.CPU_Socket] = cv.CPU_Socket;
            cvList[cn.CPU_Description] = cv.CPU_Description;
            cvList[cn.CPU_Manufacturer] = cv.CPU_Manufacturer;
            cvList[cn.RAM_BankLabel] = cv.RAM_BankLabel;
            cvList[cn.RAM_Capacity] = cv.RAM_Capacity;
            cvList[cn.RAM_Clock] = cv.RAM_Clock;
            cvList[cn.MOBO_Caption] = cv.MOBO_Caption;
            cvList[cn.MOBO_Name] = cv.MOBO_Name;
            cvList[cn.MOBO_Manufacturer] = cv.MOBO_Manufacturer;
            cvList[cn.GPU_Name] = cv.GPU_Name;
            cvList[cn.GPU_Model] = cv.GPU_Model;
            cvList[cn.GPU_Capacity] = cv.GPU_Capacity;
            cvList[cn.OS_Caption] = cv.OS_Caption;
            cvList[cn.OS_Location] = cv.OS_Location;
            cvList[cn.OS_BuildNumber] = cv.OS_BuildNumber;
            cvList[cn.OS_Version] = cv.OS_Version;
            cvList[cn.OS_FPM] = cv.OS_FPM;
            cvList[cn.OS_FVM] = cv.OS_FVM;
            cvList[cn.OS_SerialNumber] = cv.OS_SerialNumber;
            cvList[cn.OS_SystemDrive] = cv.OS_SystemDrive;
        }

        public void Clear()
        {
            cvList.Clear();
        }

        public string GetValue(string name)
        {
            return cvList[name];
        }

        public List<string> GetListName()
        {
            return cvList.Select(i => i.Key).ToList();
        }

        public List<string> GetListValue()
        {
            return cvList.Select(i => i.Value).ToList();
        }

        public int GetCount()
        {
            return cvList.Count();
        }
    }
}
