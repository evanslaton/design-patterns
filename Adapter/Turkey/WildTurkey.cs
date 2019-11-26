using System;

namespace Adapter
{
    public class WildTurkey : Turkey
    {
        public void Gobble() => Console.WriteLine("Gobble");
        public void Fly() => Console.WriteLine("I'm flying a short distance");
    }
}
