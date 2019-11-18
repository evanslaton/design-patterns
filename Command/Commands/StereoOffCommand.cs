namespace Command
{
    class StereoOffCommand : Command
    {
        public Stereo Stereo { get; set; }

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute() => Stereo.Off();
    }
}
