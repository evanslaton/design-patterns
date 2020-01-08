using CompoundPattern.duckfactories;
using CompoundPattern.goosefactories;
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
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = gooseFactory.CreateGoose();

            Console.WriteLine("Duck Simulator:");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounterDecorator.NumberOfQuacks} times");
        }

        void Simulate(IQuackable duck) => duck.Quack();
    }
}
