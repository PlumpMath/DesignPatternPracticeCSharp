using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Singleton_Pattern
{
    public class LoggerFullLazy
    {
        /// <summary>
        /// private Construcotr
        /// </summary>
        private LoggerFullLazy() { }

        private class Nested
        {
            /// <summary>
            /// Tell .NET Compiler not to mark type as beforefieldinit
            /// </summary>
            static Nested() { }

            /// <summary>
            /// Instance of this singleton, in C# outer class can't access inner class private memebers,
            /// which is quite odd, since this is not true in JAVA.
            /// </summary>
            internal static readonly LoggerFullLazy loggerInstance = new LoggerFullLazy();
        }

        /// <summary>
        /// Returns the instance, only created when the class is first accessed.
        /// </summary>
        /// <returns></returns>
        public static LoggerFullLazy GetInstance()
        {
            return Nested.loggerInstance;
        }
    }
}
