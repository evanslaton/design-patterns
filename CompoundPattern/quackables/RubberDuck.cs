using CompoundPattern.observes;
using System;

namespace CompoundPattern.quackables
{
    public class RubberDuck : IQuackable
    {
        public IQuackObservable Observable { get; set; }

        public RubberDuck()
        {
            Observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeek");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer) => Observable.RegisterObserver(observer);

        public void NotifyObservers() => Observable.NotifyObservers();
    }
}
