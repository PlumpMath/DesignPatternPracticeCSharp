using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Adapter_Pattern
{
    public interface OldLogger
    {
        void WriteLog(IList<Log> log);
        IList<Log> ReadLogs();
    }
}
