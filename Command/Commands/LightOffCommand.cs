namespace Command
{
    class LightOffCommand : Command
    {
        Light Light { get; set; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute() => Light.Off();
    }
}
