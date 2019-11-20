using System;

namespace Command
{
    class CeilingFanOffCommand : Command
    {
        public CeilingFan CeilingFan { get; set; }
        public int PreviousSpeed { get; set; }

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            PreviousSpeed = CeilingFan.Speed;
            CeilingFan.Off();
            Console.WriteLine("Ceiling fan is off.");
        }

        public void Undo()
        {
            if (PreviousSpeed == CeilingFan.HIGH)
            {
                CeilingFan.High();
                Console.WriteLine("Ceiling fan is high.");
            }
            else if (PreviousSpeed == CeilingFan.MEDIUM)
            {
                CeilingFan.Medium();
                Console.WriteLine("Ceiling fan is medium.");
            }
            else if (PreviousSpeed == CeilingFan.LOW)
            {
                CeilingFan.Low();
                Console.WriteLine("Ceiling fan is low.");
            }
            else if (PreviousSpeed == CeilingFan.OFF)
            {
                CeilingFan.Off();
                Console.WriteLine("Ceiling fan is off.");
            }
        }
    }
}
