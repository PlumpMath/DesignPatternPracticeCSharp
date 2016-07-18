using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class LightReceiver
    {
        public void On()
        {
            Console.WriteLine("Turned on the lights");
        }

        public void Off()
        {
            Console.WriteLine("Turned off the lights");
        }
    }
}
