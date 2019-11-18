namespace Command
{
    public class LightOnCommand : Command
    {
        Light Light { get; set; }

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute() => Light.On();
    }
}
