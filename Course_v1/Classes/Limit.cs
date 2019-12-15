using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_v1
{
    static class Limit
    {
        private static bool isAlive;
        private static int ltime;
        private static float lcpu;
        private static float lram;
        private static float ltcpu;
        private static double ltmobo;
        private static double lvoltage;

        public static bool isAbsoluteCPU { get; set; }
        public static bool isAbsoluteRAM { get; set; }
        public static bool isAbsoluteTCPU { get; set; }
        public static bool isAbsoluteTMobo { get; set; }
        public static bool isAbsoluteVoltage { get; set; }

        public delegate void Error(string s);
        public static event Error Notify;

        public static int Time { get; set; }
        public static int lTime { get { return ltime; }
            set { isAlive = true;
                if(value > 0 && value <= 10000){
                    ltime = value;
                }
                else if(value > 0)
                {
                    Notify?.Invoke("You entered a time less than 0s!");
                }
                else if (value > 10000)
                {
                    Notify?.Invoke("You entered a time great than 10s!");
                }
            } }

        public static float lCPU { get { return lcpu; }
            set { isAlive = true;
                if (value > 0 && value <= 100)
                {
                    lcpu = value;
                }
                else if (value > 0)
                {
                    Notify?.Invoke("You entered a load CPU less than 0%!");
                }
                else if (value > 100)
                {
                    Notify?.Invoke("You entered a load CPU great than 100%!");
                }
            } }

        public static float lRAM { get { return lram; }
            set { isAlive = true;
                if (value > 0 && value <= 100)
                {
                    lram = value;
                }
                else if (value > 0)
                {
                    Notify?.Invoke("You entered a load RAM less than 0%!");
                }
                else if (value > 100)
                {
                    Notify?.Invoke("You entered a load RAM great than 100%!");
                }
            } }

        public static float lTCPU { get { return ltcpu; }
            set { isAlive = true;
                if (value > 0 && value <= 100)
                {
                    ltcpu = value;
                }
                else if (value > 0)
                {
                    Notify?.Invoke("You entered a temperature CPU less than 0%!");
                }
                else if (value > 100)
                {
                    Notify?.Invoke("You entered a temperature CPU great than 100%!");
                }
            } }

        public static double lTMobo { get { return ltmobo; }
            set { isAlive = true;
                if (value > 0 && value <= 100)
                {
                    ltmobo = value;
                }
                else if (value > 0)
                {
                    Notify?.Invoke("You entered a temperature motherboard less than 0%!");
                }
                else if (value > 100)
                {
                    Notify?.Invoke("You entered a temperature motherboard great than 100%!");
                }
            } }

        public static double lVoltage { get { return lvoltage; }
            set { isAlive = true;
                if (value > 0 && value <= 100)
                {
                    lvoltage = value;
                }
                else if (value > 0)
                {
                    Notify?.Invoke("You entered a voltage less than 0%!");
                }
                else if (value > 100)
                {
                    Notify?.Invoke("You entered a voltage great than 100%!");
                }
            } }

        static Limit()
        {
            isAlive = false;
            //Time = 0;
            //lTime = 0;
            //lCPU = 0.0f;
            //lRAM = 0.0f;
            //lTCPU = 0.0f;
            //lTMobo = 0.0d;
            //lVoltage = 0.0f;

            isAbsoluteCPU = true;
            isAbsoluteRAM = true;
            isAbsoluteTCPU = true;
            isAbsoluteTMobo = true;
            isAbsoluteVoltage = true;
        }

        public static bool IsExist()
        {
            return isAlive;
        }

        public static void Clear()
        {
            isAlive = false;
            Time = 0;
            lTime = 0;
            lCPU = 0.0f;
            lRAM = 0.0f;
            lTCPU = 0.0f;
            lTMobo = 0.0d;
            lVoltage = 0.0f;
        }
    }
}
