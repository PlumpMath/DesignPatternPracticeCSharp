using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Singleton_Pattern
{
    public class LoggerSimpleThreadSafe
    {
        /// <summary>
        /// private reference to instance
        /// </summary>
        private static LoggerSimpleThreadSafe loggerInstance;

        /// <summary>
        /// used for synchronizing so that only one instance can be created,
        /// when this class is accessed by more than one thread.
        /// </summary>
        private static readonly object someLock=new object();

        /// <summary>
        /// private constructor to prevent creating instances
        /// </summary>
        private LoggerSimpleThreadSafe(){}

        /// <summary>
        /// public method that returns the instance,
        /// creates one if not existing.
        /// </summary>
        /// <returns></returns>
        public static LoggerSimpleThreadSafe GetInstance(){
            lock (someLock)
            {
                if(loggerInstance==null)
                {
                    loggerInstance = new LoggerSimpleThreadSafe();
                    return loggerInstance;
                }
                return loggerInstance;
            }
        }
    }
}
