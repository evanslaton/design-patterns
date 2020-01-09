using CompoundPattern.observes;

namespace CompoundPattern
{
    public interface IQuackable : IQuackObservable
    {
        public void Quack();
    }
}
