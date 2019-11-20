using System;

namespace Command
{
    public class Stereo
    {
        public Stereo() { }
        public void On() => Console.WriteLine("The stereo is on.");
        public void Off() => Console.WriteLine("The stereo is off.");
        public void SetCD() => Console.WriteLine("The CD loaded.");
        public void SetVolumn(int volumn) => Console.WriteLine($"The volume is set to {volumn}.");
    }
}
