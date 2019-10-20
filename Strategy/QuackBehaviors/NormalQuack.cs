using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
