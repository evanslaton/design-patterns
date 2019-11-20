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
            CeilingFan ceilingFan = new CeilingFan("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            Console.WriteLine(remote.ToString());

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, stereoOn, stereoOff);
            remote.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(4, ceilingFanLow, ceilingFanOff);

            Console.WriteLine(remote.ToString());

            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(0);
            remote.OffButtonWasPushed(1);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.UndoButtonWasPushed();
            remote.OffButtonWasPushed(2);
            remote.UndoButtonWasPushed();

        }
    }
}
