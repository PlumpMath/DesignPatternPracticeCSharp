using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Adapter_Pattern
{
    public class NewLoggerImpl : NewLogger
    {

        public int CreateLog(Log log)
        {
            Console.WriteLine("Creating log in new logger");
            return 0;
        }

        public IList<Log> ReadLogs()
        {
            Console.WriteLine("Fetching log in new logger");
            return new List<Log>();
        }

        public int UpdateLog(Log log)
        {
            Console.WriteLine("Updating log in new logger");
            return 0;
        }

        public int DeleteLog(Log log)
        {
            Console.WriteLine("Deleting log in new logger");
            return 0;
        }
    }
}
