using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_v1
{
    class Limit
    {
        public int lTime { get; set; }
        public float lCPU { get; set; }
        public float lRAM { get; set; }
        public float lTCPU { get; set; }
        public double lTMobo { get; set; }
        public double lVoltage { get; set; }

        public Limit()
        {
            this.lTime = 0;
            this.lCPU = 0.0f;
            this.lRAM = 0.0f;
            this.lTCPU = 0.0f;
            this.lTMobo = 0.0d;
            this.lVoltage = 0.0f;
        }
    }
}
