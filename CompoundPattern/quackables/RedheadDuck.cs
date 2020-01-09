using CompoundPattern.observes;
using System;

namespace CompoundPattern.quackables
{
    public class RedheadDuck : IQuackable
    {
        public IQuackObservable Observable { get; set; }

        public RedheadDuck()
        {
            Observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer) => Observable.RegisterObserver(observer);

        public void NotifyObservers() => Observable.NotifyObservers();
    }
}
