using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatternPratice.Adapter_Pattern
{
    public class OldLoggerImpl:OldLogger
    {
        public void WriteLog(IList<Log> logs)
        {
            Console.WriteLine("Writing log to file");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Logs.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, logs);
            stream.Close();
        }

        public IList<Log> ReadLogs()
        {
            Console.WriteLine("Reading log from file");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Logs.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            IList<Log> logs = formatter.Deserialize(stream) as IList<Log>;
            stream.Close();
            return logs;
        }
    }
}
