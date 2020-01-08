namespace CompoundPattern.quackables
{
    public class QuackCounterDecorator : IQuackable
    {
        public IQuackable Duck { get; }
        public static int NumberOfQuacks { get; private set; }

        public QuackCounterDecorator(IQuackable duck)
        {
            Duck = duck;
        }

        public void Quack()
        {
            Duck.Quack();
            NumberOfQuacks++;
        }
    }
}
