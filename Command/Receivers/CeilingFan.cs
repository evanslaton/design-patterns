namespace Command
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        public string Location { get; set; }
        public int Speed { get; set; }

        public CeilingFan(string location)
        {
            Location = location;
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
        }

        public void Medium()
        {
            Speed = MEDIUM;
        }

        public void Low()
        {
            Speed = LOW;
        }

        public void Off()
        {
            Speed = OFF;
        }
    }
}
