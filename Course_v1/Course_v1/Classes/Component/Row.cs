using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_v1
{
    public class Row
    {
        public string ComponentName { get; set; }
        public string ComponentValue { get; set; }

        public Row()
        {
            ComponentName = "";
            ComponentValue = "";
        }
    }
}