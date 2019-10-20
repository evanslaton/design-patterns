using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Duck
    {
        public FlyBehavior Fly {get; set;}
        public QuackBehavior Quack { get; set; }

        public Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior)
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
