using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class ACOnCommand : Command
    {
        private AirconditionerReceiver AC;

        public ACOnCommand(AirconditionerReceiver AC)
        {
            this.AC = AC;
        }

        public void Execute()
        {
            AC.On();
        }
    }
}
