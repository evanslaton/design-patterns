using CompoundPattern.observes;
using System;

namespace CompoundPattern.quackables
{
    public class DuckCall : IQuackable
    {
        public IQuackObservable Observable { get; set; }

        public DuckCall()
        {
            Observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer) => Observable.RegisterObserver(observer);

        public void NotifyObservers() => Observable.NotifyObservers();
    }
}
