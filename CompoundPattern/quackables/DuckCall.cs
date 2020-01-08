using System;

namespace CompoundPattern.quackables
{
    public class DuckCall : IQuackable
    {
        public void Quack() => Console.WriteLine("Kwak");
    }
}
