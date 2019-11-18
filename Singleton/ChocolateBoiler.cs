namespace Singleton
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler CHOCOLATE_BOILER = new ChocolateBoiler();
        //For lazy instantiation -> can cause issues with multi-threading
        //private static ChocolateBoiler CHOCOLATE_BOILER = null;
        private bool Empty { get; set; }
        private bool Boiled { get; set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance() => CHOCOLATE_BOILER;

        //For lazy instantiation
        //public static ChocolateBoiler GetInstance()
        //{
        //    if (CHOCOLATE_BOILER == null) CHOCOLATE_BOILER = new ChocolateBoiler();
        //    return CHOCOLATE_BOILER;
        //}

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }

        public override string ToString() => $"\nEmpty: {Empty}\nBoiled: {Boiled}";
    }
}
