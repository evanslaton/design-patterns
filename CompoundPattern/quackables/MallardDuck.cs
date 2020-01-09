using CompoundPattern.observes;
using System;

namespace CompoundPattern.quackables
{
    public class MallardDuck : IQuackable
    {
        public IQuackObservable Observable { get; set; }

        public MallardDuck()
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
