namespace CompoundPattern.observes
{
    public interface IQuackObservable
    {
        public void RegisterObserver(IQuackObserver);
        public void NotifyObservers();
    }
}
