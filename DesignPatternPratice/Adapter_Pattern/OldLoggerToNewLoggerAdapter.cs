using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Adapter_Pattern
{
    public class OldLoggerToNewLoggerAdapter : NewLogger
    {
        private OldLogger oldLogger;

        public OldLoggerToNewLoggerAdapter(OldLogger oldLogger)
        {
            this.oldLogger = oldLogger;
        }

        public int CreateLog(Log log)
        {
            Console.WriteLine("Creating Log from adapter");
            IList<Log> logs = new List<Log>();
            logs.Add(log);
            oldLogger.WriteLog(logs);
            return 0;
        }

        public IList<Log> ReadLogs()
        {
            Console.WriteLine("Reading log from adapter");
            IList<Log> logs = oldLogger.ReadLogs();
            return logs;
        }

        public int UpdateLog(Log log)
        {
            Console.WriteLine("Updating log from adapter");
            IList<Log> logs = oldLogger.ReadLogs();
            foreach (Log l in logs)
            {
                if (l.LogSubject == log.LogSubject)
                {
                    l.LogSubject = log.LogSubject;
                }
            }
            oldLogger.WriteLog(logs);
            return 0;
        }

        public int DeleteLog(Log log)
        {
            Console.WriteLine("Deleting log from adapter");
            IList<Log> logs = oldLogger.ReadLogs();
            logs.Remove(log);
            return 0;
        }
    }
}
