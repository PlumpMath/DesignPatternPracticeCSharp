using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Facade_Pattern
{
    public class AirConditioner
    {
        public void On()
        {
            Console.WriteLine("Turned on Air Conditioner");
        }

        public void Off()
        {
            Console.WriteLine("Turned off Air Conditioner");
        }
    }
}
