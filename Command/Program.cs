using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light livingRoomLight = new Light();
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            Console.WriteLine(remote.ToString());

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, stereoOn, stereoOff);

            Console.WriteLine(remote.ToString());

            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(0);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
        }
    }
}
