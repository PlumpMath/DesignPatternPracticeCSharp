using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Facade_Pattern
{
    public class ModeSwitcherFacade
    {
        private AirConditioner ac;
        private Light light;
        private Fan fan;
        private Notebook nb;

        public ModeSwitcherFacade(AirConditioner ac, Light light, Fan fan, Notebook nb)
        {
            this.ac = ac;
            this.light = light;
            this.fan = fan;
            this.nb = nb;
        }

        public void SetMovieMode()
        {
            Console.WriteLine("Switching to movie mode");
            nb.On();
            light.On();
            fan.On();
        }

        public void SetGamingMode()
        {
            Console.WriteLine("Switching to gaming mode");
            nb.On();
            light.Off();
            ac.On();
        }
    }
}
