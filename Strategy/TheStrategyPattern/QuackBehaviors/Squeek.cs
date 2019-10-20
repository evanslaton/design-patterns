using System;

namespace Strategy
{
    public class Squeek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeek");
        }
    }
}
