using System;
using System.Text;
namespace Course_v1
{
    static class Limit
    {
        private static int ltime;
        private static float lcpu;
        private static float lram;
        private static float ltcpu;
        private static float ltmobo;
        private static float lvoltage;

        public static bool isAlive { get; set; }
        public static bool isAbsoluteTCPU { get; set; }
        public static bool isAbsoluteTMobo { get; set; }
        public static bool isAbsoluteVoltage { get; set; }

        public delegate void Error(string s);
        public static event Error Notify;

        public static int Time { get; set; }
        public static int lTime
        {
            get { return ltime; }
            set
            {
                if (value > 0 && value <= 10000)
                {
                    ltime = value;
                }
                else if (value > 0)
                {
                    isAlive = false;
                    Notify?.Invoke("You entered a time less than 0s!");
                }
                else if (value > 10000)
                {
                    isAlive = false;
                    Notify?.Invoke("You entered a time great than 10s!");
                }
            }
        }

        public static float lCPU
        {
            get { return lcpu; }
            set
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
        }

        public static float lRAM
        {
            get { return lram; }
            set
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
        }
        public static float lTCPU
        {
            get { return ltcpu; }
            set
            {
                var min = 5.0f;//0%
                var max = 75.0f;//100%

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

        public static float lVoltage
        {
            get { return lvoltage; }
            set
            {
                //if PSU = ~1/~5/~12V
                // if battery = 11.400 V
                // if CPU = 0.9 V

                var min = 10.0f;//0%
                var max = 15.0f;//100%
                if (isAbsoluteVoltage == false)
                {
                    if (value >= 0.0f && value <= 0.0f)
                    {
                        lvoltage = value;
                    }
                    else if (value < 0.0f)
                    {
                        Notify?.Invoke("You entered a voltage \rless than 0%!");
                    }
                    else if (value > 100.0f)
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
            lVoltage = 0.0f;
        }
        public static string getThreshold()
        {
            StringBuilder sb = new StringBuilder("Threshold:");
            int countParams = 0;
            bool cFlag = false;

            if (Limit.lCPU != 0.0f)
            {
                sb.Append($" CPU: {Limit.lCPU}%");
                countParams++;
            }
            if (Limit.lRAM != 0.0f)
            {
                sb.Append($" RAM: {Limit.lRAM}%");
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
            if (Limit.lVoltage != 0.0f)
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
