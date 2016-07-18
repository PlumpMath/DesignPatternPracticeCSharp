using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPratice.Command_Pattern
{
    public class MacroCommand:Command
    {
        private IList<Command> commands;

        public MacroCommand()
        {
            commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (Command c in commands)
            {
                c.Execute();
            }
        }
    }
}
