using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost() => 1.99;
    }
}
