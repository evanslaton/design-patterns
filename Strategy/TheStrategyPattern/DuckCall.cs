using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DuckCall
    {
        public IQuackBehavior QuackBehavior { get; set; }

        public DuckCall()
        {
            this.QuackBehavior = new NormalQuack();
        }

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }
    }
}
