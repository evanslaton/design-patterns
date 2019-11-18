using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleRemoteControl
    {
        public Command Slot { get; set; }

        public SimpleRemoteControl() { }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
