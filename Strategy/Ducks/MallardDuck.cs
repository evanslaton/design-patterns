using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) : base(flyBehavior, quackBehavior) {}

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
