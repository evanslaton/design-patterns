using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class HomeTheaterFacade
    {
        public PopcornPopper Popper { get; set; }
        public TheaterLights Lights { get; set; }
        public Screen Screen { get; set; }
        public DvdPlayer Dvd { get; set; }
        public CdPlayer Cd { get; set; }
        public Tuner Tuner { get; set; }
        public Projector Projector { get; set; }
        public Amplifier Amp { get; set; }

        public HomeTheaterFacade(PopcornPopper popper, 
                                TheaterLights lights, 
                                Screen screen, 
                                DvdPlayer dvd, 
                                CdPlayer cd, 
                                Tuner tuner, 
                                Projector projector, 
                                Amplifier amp)
        {
            Popper = popper;
            Lights = lights;
            Screen = screen;
            Dvd = dvd;
            Cd = cd;
            Tuner = tuner;
            Projector = projector;
            Amp = amp;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a move:");
            Popper.On();
            Popper.Pop();
            Popper.Off();
            Lights.Dim();
            Screen.Down();
            Projector.On();
            Amp.On();
            Amp.SetDvd("Hook");
            Dvd.On();
            Dvd.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down:");
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amp.Off();
            Dvd.Stop();
            Dvd.Eject();
            Dvd.Off();
        }
    }
}
