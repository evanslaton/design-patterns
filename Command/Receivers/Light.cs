using System;

namespace Command
{
    public class Light
    {
        public Light() { }
        public void On() => Console.WriteLine("The light is on.");
        public void Off() => Console.WriteLine("The light is off.");
    }
}
