using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck(new FlyWithWings(), new NormalQuack());
            Console.WriteLine("Mallard:");
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();

            Console.WriteLine("\nDuck Call:");
            DuckCall duckCall = new DuckCall();
            duckCall.PerformQuack();
        }
    }
}
