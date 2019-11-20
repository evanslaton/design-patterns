namespace Command
{
    class StereoOnCommand : Command
    {
        public Stereo Stereo { get; set; }

        public StereoOnCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolumn(10);
        }

        public void Undo() => Stereo.Off();
    }
}
