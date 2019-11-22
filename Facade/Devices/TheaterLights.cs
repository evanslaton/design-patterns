using System;

namespace Facade
{
    class TheaterLights
    {
        public void On() => Console.WriteLine("Lights are on");
        public void Off() => Console.WriteLine("Lights are off");
        public void Dim() => Console.WriteLine("Lights are dimmed");
    }
}
