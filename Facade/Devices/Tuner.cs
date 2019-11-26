using System;

namespace Facade
{
    class Tuner
    {
        public Amplifier Amplifier { get; set; }
        public string Am { get; set; }
        public string Pm { get; set; }

        public void On() => Console.WriteLine($"Tuner is on {Am} or {Pm}");
        public void Off() => Console.WriteLine("Tuner is on");
    }
}
