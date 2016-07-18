using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    //This class acts as the Invoker
    public class RemoteControl
    {
        public Command LightOnCommand { get; set; }
        public Command LightOffCommand { get; set; }

        public Command AirConditionerOnCommand { get; set; }
        public Command AirConditionerOffCommand { get; set; }

        public Command macroCommand { get; set; }

        public void LightOn()
        {
            LightOnCommand.Execute();
        }

        public void LightOff()
        {
            LightOffCommand.Execute();
        }

        public void ACON(){
            AirConditionerOnCommand.Execute();
        }
        public void ACOFF(){
            AirConditionerOffCommand.Execute();
        }

        public void PartyOn()
        {
            macroCommand.Execute();
        }
    }
}
