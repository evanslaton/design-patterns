using CompoundPattern.quackables;

namespace CompoundPattern.duckfactories
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck() => new QuackCounterDecorator(new MallardDuck());
        public override IQuackable CreateRedheadDuck() => new QuackCounterDecorator(new RedheadDuck());
        public override IQuackable CreateDuckCall() => new QuackCounterDecorator(new DuckCall());
        public override IQuackable CreateRubberDuck() => new QuackCounterDecorator(new RubberDuck());
    }
}
