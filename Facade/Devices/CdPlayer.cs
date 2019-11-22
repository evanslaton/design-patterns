using System;

namespace Facade
{
    class CdPlayer
    {
        public Amplifier Amplifier { get; set; }
        public string Cd { get; set; }

        public void On() => Console.WriteLine("CD Player is on");
        public void Off() => Console.WriteLine("CD Player is on");
        public void Eject() => Console.WriteLine("Ejecting CD");
        public void Pause() => Console.WriteLine("Pausing CD");
        public void Play() => Console.WriteLine("Playing CD");
        public void Stop() => Console.WriteLine("Stop playing CD");
    }
}
