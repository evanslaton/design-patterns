using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Squeek : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeek");
        }
    }
}
