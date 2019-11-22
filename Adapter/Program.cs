using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says:");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says:");
            TestDuck(duck);

            Console.WriteLine("\nThe turkeyAdapter says:");
            TestDuck(turkeyAdapter);
        }

        public static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
