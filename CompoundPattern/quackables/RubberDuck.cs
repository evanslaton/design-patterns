using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.quackables
{
    public class RubberDuck : IQuackable
    {
        public void Quack() => Console.WriteLine("Squeak");
    }
}
