using CompoundPattern.duckfactories;
using CompoundPattern.goosefactories;
using CompoundPattern.observers;
using CompoundPattern.quackables;
using System;

namespace CompoundPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new GooseDecoratorFactory();
            program.Simulate(duckFactory, gooseFactory);
        }

        void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            Console.WriteLine("Duck Simulator: With Compsoite - Flock");

            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = gooseFactory.CreateGoose();

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            IQuackable mallardDuckOne = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckThree = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckFour = duckFactory.CreateMallardDuck();

            Flock flockOfMallards = new Flock();
            flockOfMallards.Add(mallardDuckOne);
            flockOfMallards.Add(mallardDuckTwo);
            flockOfMallards.Add(mallardDuckThree);
            flockOfMallards.Add(mallardDuckFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            Simulate(flockOfDucks);

            Console.WriteLine($"\nThe ducks quacked {QuackCounterDecorator.NumberOfQuacks} times");
        }

        void Simulate(IQuackable duck) => duck.Quack();
    }
}
