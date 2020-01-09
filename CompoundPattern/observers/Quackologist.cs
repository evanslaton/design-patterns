using System;
using CompoundPattern.observes;

namespace CompoundPattern.observers
{
    class Quackologist : IQuackObserver
    {
        public void Update(IQuackObservable duck) => Console.WriteLine($"Quackologist: {duck} just quacked");
    }
}
