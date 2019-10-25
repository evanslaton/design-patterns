using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description { get; set; }

        public string GetDescription() => Description;

        public abstract double Cost();
    }
}
