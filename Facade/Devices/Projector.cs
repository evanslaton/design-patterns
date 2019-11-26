using System;

namespace Facade
{
    class Projector
    {
        public  DvdPlayer DvdPlayer { get; set; }

        public Projector(DvdPlayer dvdPlayer)
        {
            DvdPlayer = dvdPlayer;
        }

        public void On() => DvdPlayer.On();
        public void Off() => DvdPlayer.Off();
        public void TvMode() => Console.WriteLine("DVD Player is on TV mode");
        public void WideScreenMode() => Console.WriteLine("DVD Player is on widescreen mode");
    }
}
