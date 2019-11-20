using System;

namespace Command
{
    public class CeilingFanMediumCommand : Command
    {
        public CeilingFan CeilingFan { get; set; }
        public int PreviousSpeed { get; set; }

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            PreviousSpeed = CeilingFan.Speed;
            CeilingFan.Medium();
            Console.WriteLine("Ceiling fan is on medium.");
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
