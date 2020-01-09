using System.Collections.Generic;

namespace CompoundPattern
{
    public class Flock : IQuackable
    {
        List<IQuackable> Quackers = new List<IQuackable>();

        public void Add(IQuackable quackable) => Quackers.Add(quackable);

        public void Quack()
        {
            IEnumerator<IQuackable> enumerator = Quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.Quack();
            }
        }
    }
}
