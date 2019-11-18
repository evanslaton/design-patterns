using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Command
{
    class RemoteControl
    {
        private int SLOTS = 7;
        public Command[] OnCommands { get; set; }
        public Command[] OffCommands { get; set; }

        public RemoteControl()
        {
            OnCommands = new Command[SLOTS];
            OffCommands = new Command[SLOTS];
            Command noCommand = new NoCommand();
            for (int i = 0; i < SLOTS; i++) OnCommands[i] = OffCommands[i] = noCommand;
        }
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot) => OnCommands[slot].Execute();
        public void OffButtonWasPushed(int slot) => OffCommands[slot].Execute();

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < SLOTS; i++)
            {
                output.Append($"Slot {i} -> On: {OnCommands[i].GetType().Name}, Off: {OffCommands[i].GetType().Name}\n");
            }
            return output.ToString();
        }
    }
}
