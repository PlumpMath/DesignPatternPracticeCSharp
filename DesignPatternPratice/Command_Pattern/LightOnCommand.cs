using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class LightOnCommand:Command
    {
        private LightReceiver light;
        public LightOnCommand(LightReceiver light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
