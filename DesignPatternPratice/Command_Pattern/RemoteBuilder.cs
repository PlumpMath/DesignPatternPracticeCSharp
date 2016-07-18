using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class RemoteBuilder
    {
        public static RemoteControl MakeRemote()
        {
            LightReceiver light=new LightReceiver();
            AirconditionerReceiver AC=new AirconditionerReceiver();

            Command lightOnCommand = new LightOnCommand(light);
            Command lightOffCommand = new LightOffCommand(light);
            Command acOnCommand = new ACOnCommand(AC);
            Command acOffCommand = new ACOffCommand(AC);

            MacroCommand partyCommand = new MacroCommand();
            partyCommand.AddCommand(lightOnCommand);
            partyCommand.AddCommand(acOnCommand);

            RemoteControl remote = new RemoteControl();
            remote.LightOnCommand = lightOnCommand;
            remote.LightOffCommand = lightOffCommand;
            remote.AirConditionerOffCommand = acOnCommand;
            remote.AirConditionerOnCommand = acOffCommand;
            remote.macroCommand = partyCommand;

            return remote;
        }
    }
}
