using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Adapter_Pattern
{
    public interface NewLogger
    {
        int CreateLog(Log log);
        IList<Log> ReadLogs();
        int UpdateLog(Log log);
        int DeleteLog(Log log);
    }
}
