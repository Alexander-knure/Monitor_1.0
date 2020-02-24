using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Course_v1
{
    public class Statistic
    {
        public int Time { get; set; }
        public float CPU { get; set; }
        public float RAM { get; set; }
        public float TCPU { get; set; }
        public float TMobo { get; set; }
        public float Voltage { get; set; }

        public Statistic()
        {
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

        public List<int> GetListTime()
        {
            return sList.Select(i => i.Time).ToList();
        }
        public List<float> GetListCPU()
        {
            return sList.Select(i => i.CPU).ToList();
        }
        public List<float> GetListRAM()
        {
            return sList.Select(i => i.RAM).ToList();
        }

        public List<float> GetListTCPU()
        {
            return sList.Select(i => i.TCPU).ToList();
        }

        public List<float> GetListTMobo()
        {
            return sList.Select(i => i.TMobo).ToList();
        }
         
        public List<float> GetListVoltage()
        {
            return sList.Select(i => i.Voltage).ToList();
        }

        public void Add(Statistic s)
        {
            this.sList.Add(s);
        }

        public int GetCount()
        {
            return sList.Count();
        }
    }
}


