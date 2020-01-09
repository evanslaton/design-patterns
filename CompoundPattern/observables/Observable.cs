using System.Collections.Generic;

namespace CompoundPattern.observes
{
    public class Observable : IQuackObservable
    {
        public List<IQuackObserver> Observers { get; set; }
        public IQuackObservable Duck { get; set; }

        public Observable(IQuackObservable duck)
        {
            Observers = new List<IQuackObserver>();
            Duck = duck;
        }

        public void RegisterObserver(IQuackObserver observer) =>  Observers.Add(observer);

        public void NotifyObservers()
        {
            foreach (IQuackObserver observer in Observers)
            {
                observer.Update(Duck);
            }
        }

    
    }
}
