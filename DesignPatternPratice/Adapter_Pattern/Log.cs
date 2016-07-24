using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Adapter_Pattern
{
    [Serializable]
    public class Log
    {
        public string LogSubject { get; set; }
        public string LogContent { get; set; }
        public DateTime LogTime { get; set; }
    }
}
