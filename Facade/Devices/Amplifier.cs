using System;

namespace Facade
{
    class Amplifier
    {
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }

        public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer)
        {
            Tuner = tuner;
            DvdPlayer = dvdPlayer;
            CdPlayer = cdPlayer;
        }

        public void On() => Console.WriteLine("Amplifier is on");
        public void Off() => Console.WriteLine("Amplifier is off");
        public void SetCd(string cd) => CdPlayer.Cd = cd;
        public void SetDvd(string dvd) => DvdPlayer.Dvd = dvd;
        public void SetTunerAm(string am) => Tuner.Am = am;
        public void SetTunerPm(string pm) => Tuner.Pm = pm;

    }
}
