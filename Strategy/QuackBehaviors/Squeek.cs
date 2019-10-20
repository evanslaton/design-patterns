using System;
using System.Collections.Generic;
using System.Text;

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
