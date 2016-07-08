using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Singleton_Pattern
{
    /// <summary>
    /// No thread safe, lazy initialization
    /// </summary>
    public class LoggerNoThreadSafe
    {
        private static LoggerNoThreadSafe loggerInstance;

        /// <summary>
        /// Private constructor to prevent creating instances
        /// </summary>
        private LoggerNoThreadSafe() { }

        /// <summary>
        /// Returns singleton instance
        /// </summary>
        /// <returns></returns>
        public static LoggerNoThreadSafe GetInstance()
        {
            //If instance has not yet been created.
            if (loggerInstance == null)
            {
                loggerInstance = new LoggerNoThreadSafe();
                return loggerInstance;
            }
            //return the instance instead.
            return loggerInstance;
        }

        //Utility method for logging
        public void Log(string message)
        {
            //Write to console IO instead of file or db for simplicity.
            Console.WriteLine("Time:{0},Message:{1}", DateTime.Now.ToString(), message);
        }
    }
}
