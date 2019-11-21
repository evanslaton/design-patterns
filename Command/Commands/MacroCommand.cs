using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class MacroCommand : Command
    {
        public Command[] Commands { get; set; }

        public MacroCommand(Command[] commands)
        {
            Commands = commands;
        }

        public void Execute()
        {
            foreach (Command command in Commands) command.Execute();
        }

        public void Undo()
        {
            foreach (Command command in Commands) command.Undo();
        }
    }
}
