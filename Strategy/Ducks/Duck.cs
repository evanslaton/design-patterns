using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior Fly {get; set;}
        public IQuackBehavior Quack { get; set; }

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.Fly = flyBehavior;
            this.Quack = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            this.Fly.Fly();
        }

        public void PerformQuack()
        {
            this.Quack.Quack();
        }
    }
}
