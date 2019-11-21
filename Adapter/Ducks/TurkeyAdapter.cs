namespace Adapter
{
    public class TurkeyAdapter : Duck
    {
        public Turkey Turkey { get; set; }

        public TurkeyAdapter(Turkey turkey)
        {
            Turkey = turkey;
        }

        public void Quack() => Turkey.Gobble();

        public void Fly()
        {
            for (int i = 0; i < 5; i++) Turkey.Fly();
        }
    }
}
