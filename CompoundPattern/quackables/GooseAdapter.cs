namespace CompoundPattern.quackables
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack() => this.goose.Honk();
    }
}
