namespace CompoundPattern.observes
{
    public interface IQuackObservable
    {
        public void RegisterObserver(IQuackObserver quackObserver);
        public void NotifyObservers();
    }
}
