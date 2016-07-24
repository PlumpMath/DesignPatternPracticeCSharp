using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Facade_Pattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Turned on Lights");
        }

        public void Off()
        {
            Console.WriteLine("Turned off Lights");
        }
    }
}
