using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class LightOffCommand : Command
    {
        private LightReceiver light;
        public LightOffCommand(LightReceiver light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
