using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
