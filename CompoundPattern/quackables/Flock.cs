using CompoundPattern.observes;
using System.Collections.Generic;

namespace CompoundPattern
{
    public class Flock : IQuackable
    {
        public List<IQuackable> Quackers { get; set; }
        public IQuackObservable Observable { get; set; }

        public Flock()
        {
            Quackers = new List<IQuackable>();
            Observable = new Observable(this);
        }

        public void Add(IQuackable quackable) => Quackers.Add(quackable);

        public void Quack()
        {
            IEnumerator<IQuackable> enumerator = Quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.Quack();
            }
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            IEnumerator<IQuackable> enumerator = Quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            IEnumerator<IQuackable> enumerator = Quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.NotifyObservers();
            }
        }
    }
}
