using FactoryMethodPattern.Ingredients.Dough;
using FactoryMethodPattern.Ingredients.Sauce;
using FactoryMethodPattern.Ingredients.Veggies;
using FactoryMethodPattern.Ingredients.Cheese;
using FactoryMethodPattern.Ingredients.Pepperoni;
using FactoryMethodPattern.Ingredients.Clams;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clam { get; set; }

        public abstract void Prepare();
        public void Bake() => Console.WriteLine("Baking for 25 minutes at 350 degrees.");
        public void Cut() => Console.WriteLine("Cutting the pizza.");
        public void Box() => Console.WriteLine("Putting pizza in a box.");
        public override string ToString() {
            return $"{Dough}, {Sauce}, {Cheese}";
        }
    }
}
