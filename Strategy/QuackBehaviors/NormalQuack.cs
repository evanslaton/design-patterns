using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class NormalQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
