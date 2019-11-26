using System;

namespace Facade
{
    class DvdPlayer
    {
        public Amplifier Amplifier { get; set; }
        public string Dvd { get; set; }

        public void On() => Console.WriteLine("DVD Player is on");
        public void Off() => Console.WriteLine("DVD Player is off");
        public void Eject() => Console.WriteLine("Ejecting DVD");
        public void Pause() => Console.WriteLine("Pausing DVD");
        public void Play() => Console.WriteLine("Playing DVD");
        public void Stop() => Console.WriteLine("Stop playing DVD");
    }
}
