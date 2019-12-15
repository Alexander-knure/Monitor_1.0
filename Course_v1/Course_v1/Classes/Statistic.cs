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
    public class Statistic
    {
        public int Time { get; set; }
        public float CPU { get; set; }
        public float RAM { get; set; }
        public float TCPU { get; set; }
        public double TMobo { get; set; }
        public double Voltage { get; set; }

        public Statistic()
        {
            this.Time = 0;
            this.CPU = 0.0f;
            this.RAM = 0.0f;
            this.TCPU = 0.0f;
            this.TMobo = 0.0d;
            this.Voltage = 0.0f;
        }
    }

    [Serializable]
    public class StatisticList
    {
        public List<Statistic> sList { get; set; }

        public StatisticList()
        {
            this.sList = new List<Statistic>();
        }

        public void Add(Statistic s)
        {
            this.sList.Add(s);
        }
        
        public List<int> GetListTime()
        {
            var list = new List<int>();
            foreach (var item in sList)
                list.Add(item.Time);

            return list;
        }
        public List<float> GetListCPU()
        {
            var list = new List<float>();
            foreach (var item in sList)
                list.Add(item.CPU);

            return list;
        }

        public List<float> GetListRAM()
        {
            var list = new List<float>();
            foreach (var item in sList)
                list.Add(item.RAM);

            return list;
        }

        public List<float> GetListTCPU()
        {
            var list = new List<float>();
            foreach (var item in sList)
                list.Add(item.TCPU);

            return list;
        }

        public List<double> GetListTMobo()
        {
            var list = new List<double>();
            foreach (var item in sList)
                list.Add(item.TMobo);

            return list;
        }

        public List<double> GetListVoltage()
        {
            var list = new List<double>();
            foreach (var item in sList)
                list.Add(item.Voltage);

            return list;
        }

        public int GetCount()
        {
            return sList.Count();
        }
    }
}
