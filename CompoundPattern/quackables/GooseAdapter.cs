using CompoundPattern.observes;

namespace CompoundPattern.quackables
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;
        public IQuackObservable Observable { get; set; }

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            Observable = new Observable(this);
        }

        public void Quack()
        {
            this.goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer) => Observable.RegisterObserver(observer);

        public void NotifyObservers() => Observable.NotifyObservers();
    }
}
