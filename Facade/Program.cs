using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            PopcornPopper popper = new PopcornPopper();
            TheaterLights lights = new TheaterLights();
            Screen screen = new Screen();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Tuner tuner = new Tuner();
            Projector projector = new Projector(dvd);
            Amplifier amp = new Amplifier(tuner, dvd, cd);

            HomeTheaterFacade facade = new HomeTheaterFacade(popper, lights, screen, dvd,
                                                            cd, tuner, projector, amp);
            facade.WatchMovie();
            Console.WriteLine();
            facade.EndMovie();
        }
    }
}
