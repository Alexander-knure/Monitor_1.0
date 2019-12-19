using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_v1
{
    static class Limit
    {
        private static int ltime;
        private static float lcpu;
        private static float lram;
        private static float ltcpu;
        private static float ltmobo;
        private static decimal lvoltage;

        public static bool isAlive { get; set; }
        public static bool isAbsoluteCPU { get; set; }
        public static bool isAbsoluteRAM { get; set; }
        public static bool isAbsoluteTCPU { get; set; }
        public static bool isAbsoluteTMobo { get; set; }
        public static bool isAbsoluteVoltage { get; set; }

        public delegate void Error(string s);
        public static event Error Notify;

        public static int Time { get; set; }
        public static int lTime { get { return ltime; }
            set {
                if(value > 0 && value <= 10000){
                    ltime = value;
                }
                else if(value > 0)
                {
                    isAlive = false;
                    Notify?.Invoke("You entered a time less than 0s!");
                }
                else if (value > 10000)
                {
                    isAlive = false;
                    Notify?.Invoke("You entered a time great than 10s!");
                }
            } }

        public static float lCPU
        {
            get { return lcpu; }
            set
            {
                if (isAbsoluteCPU == false)
                {
                    if (value >= 0.0f && value <= 100.0f)
                    {
                        lcpu = value;
                    }
                    else if (value < 0.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a load CPU \rless than 0%!");
                    }
                    else if (value > 100.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a load CPU \rgreat than 100%!");
                    }
                }
                else
                {
                    isAlive = false;
                    Notify?.Invoke("You choose \"absolute\" \rload CPU less!");
                }
            }
        }

        public static float lRAM
        {
            get { return lram; }
            set
            {
                if (isAbsoluteRAM == false)
                {
                    if (value >= 0.0f && value <= 100.0f)
                    {
                        lram = value;
                    }
                    else if (value < 0.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a load RAM \rless than 0%!");
                    }
                    else if (value > 100.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a load RAM \rgreat than 100%!");
                    }
                }
                else
                {
                    isAlive = false;
                    Notify?.Invoke("You choose \"absolute\" load RAM less!");
                }
            }
        }

        public static float lTCPU
        {
            get { return ltcpu; }
            set
            {
                var min = 5.0f;//0%
                var max = 70.0f;//100%

                if (isAbsoluteTCPU == false)
                {                    
                    if (value >= 0.0f && value <= 100.0f)
                    {
                        ltcpu = value;
                    }
                    else if (value < 0.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a temperature \rCPU less than 0%!");
                    }
                    else if (value > 100.0f)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a temperature \rCPU great than 100%!");
                    }
                }
                else
                {
                    if (value >= min && value <= max)
                    {
                        ltcpu = value * (max - min) + min;
                    }
                    else if (value < min)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a temperature \rCPU less than 5°C!");
                    }
                    else if (value > max)
                    {
                        isAlive = false;
                        Notify?.Invoke("You entered a temperature \rCPU great than 70°C!");
                    }
                }
            }
        }

        public static float lTMobo
        {

            get { return ltmobo; }
            set
            {
                var min = 5.0f;//0%
                var max = 65.0f;//100%
                if (isAbsoluteTMobo == false)
                {
                    if (value >= 0.0f && value <= 100.0f)
                    {
                        ltmobo = value;
                    }
                    else if (value < 0.0f)
                    {
                        Notify?.Invoke("You entered a temperature \rmotherboard less than 0%!");
                    }
                    else if (value > 100.0f)
                    {
                        Notify?.Invoke("You entered a temperature \rmotherboard great than 100%!");
                    }
                }
                else
                {
                    if (value >= min && value <= max)
                    {
                        ltcpu = value * (max - min) + min;
                    }
                    else if (value < min)
                    {
                        Notify?.Invoke("You entered a temperature \rmotherboard less than 5°C!");
                    }
                    else if (value > max)
                    {
                        Notify?.Invoke("You entered a temperature \rmotherboard great than 65°C!");
                    }
                }
            }
        }

        public static decimal lVoltage
        {
            get { return lvoltage; }
            set
            {

                //if PSU = ~1/~5/~12V
                // if battery = 11.400 V
                // if CPU = 0.9 V

                var min = 0.5M;//0%
                var max = 15.0M;//100%
                if (isAbsoluteVoltage == false)
                {
                    if (value >= 0 && value <= 0)
                    {
                        lvoltage = value;
                    }
                    else if (value < 0)
                    {
                        Notify?.Invoke("You entered a voltage \rless than 0%!");
                    }
                    else if (value > 0)
                    {
                        Notify?.Invoke("You entered a voltage great \rthan 100%!");
                    }
                }
                else
                {
                    if (value > min && value <= max)
                    {
                        lvoltage = value * (max - min) + min;
                    }
                    else if (value < min)
                    {
                        Notify?.Invoke("You entered a voltage less than 0.5V!");
                    }
                    else if (value > max)
                    {
                        Notify?.Invoke("You entered a voltage great than 15.0V!");
                    }
                }
            }
        }

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

        public static void Clear()
        {
            Time = 0;
            lTime = 0;
            lCPU = 0.0f;
            lRAM = 0.0f;
            lTCPU = 0.0f;
            lTMobo = 0.0f;
            lVoltage = 0.0M;
        }

        public static string getThreshold()
        {
            StringBuilder sb = new StringBuilder("Threshold:");
            int countParams = 0;
            bool cFlag = false;

            if (Limit.lCPU != 0.0f)
            {
                if (Limit.isAbsoluteCPU == false)
                    sb.Append($" CPU: {Limit.lCPU}%");
                else
                    sb.Append($" CPU: {Limit.lCPU}p");
                countParams++;
            }
            if (Limit.lRAM != 0.0f)
            {
                if (Limit.isAbsoluteRAM == false)
                    sb.Append($" RAM: {Limit.lRAM}%");
                else
                    sb.Append($" RAM: {Limit.lRAM}p");
                countParams++;
            }
            if (countParams > 2 && cFlag == false)
            {
                cFlag = true;
                sb.Append(" \r");
            }
            if (Limit.lTCPU != 0.0f)
            {
                if (Limit.isAbsoluteTCPU == false)
                    sb.Append($" CPU t: {Limit.lTCPU}%");
                else
                    sb.Append($" CPU t: {Limit.lTCPU}°C");
                countParams++;
            }
            if (countParams > 2 && cFlag == false)
            {
                cFlag = true;
                sb.Append(" \r");
            }
            if (Limit.lTMobo != 0.0f)
            {
                if (Limit.isAbsoluteTMobo == false)
                    sb.Append($" MB t: {Limit.lTMobo}%");
                else
                    sb.Append($" MB t: {Limit.lTMobo}°C");
                countParams++;
            }
            if (countParams > 2 && cFlag == false)
                sb.Append(" \r");
            if (Limit.lVoltage != 0.0M)
            {
                if (Limit.isAbsoluteVoltage == false)
                    sb.Append($" Voltage: {Limit.lVoltage}%");
                else
                    sb.Append($" Voltage: {Limit.lVoltage}V");
                countParams++;
            }

            return sb.ToString();
        }
    }
}
