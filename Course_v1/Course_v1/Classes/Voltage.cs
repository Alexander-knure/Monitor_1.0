using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Management;

namespace Course_v1.Classes
{
    public class Voltage
    {
        private static ManagementObjectSearcher mosPS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + "Win32_Battery");
        private static Object v;
        public static int VoltageCount {
            get
            {
                foreach (ManagementObject mo in mosPS.Get())
                {
                
                    v =mo["DesignVoltage"];
                }
                return Convert.ToInt32(v);
            }
        }
   
}

    public class Program
    {
        // Вспомогательный метод для создания категории счетчика
        public static void CreateCounterCategory()
        {
            if (PerformanceCounterCategory.Exists("Voltage"))
                PerformanceCounterCategory.Delete("Voltage");

            CounterCreationDataCollection counters = new CounterCreationDataCollection();

            CounterCreationData voltage = new CounterCreationData("# Supply voltage",
                "Количество пользователей, работающих в данный момент с вашим приложением",
                PerformanceCounterType.NumberOfItems64);

            counters.Add(voltage);

            PerformanceCounterCategory.Create("Voltage", "Supply voltage", counters);
           
        }

        // Этот метод нужно использовать для запуска счетчика
        public static void StartUpdatingCounters()
        {
            PerformanceCounter usersAtWork = new PerformanceCounter("Voltage",
                "# Supply voltage", false);

            Timer updateTimer = new Timer(_ =>
            {
                // Обновляем значение счетчика
                usersAtWork.RawValue = Voltage.VoltageCount;
            },
            null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }
    }
}
