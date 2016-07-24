using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Facade_Pattern
{
    public class Fan
    {
        public void On()
        {
            Console.WriteLine("Turned on Fan");
        }

        public void Off()
        {
            Console.WriteLine("Turned off Fan");
        }
    }
}
