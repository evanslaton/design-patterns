using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}.");
            Console.WriteLine($"Making dough...");
            Console.WriteLine($"Adding sauce...");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($" -{topping}");
            }
        }

        public void Bake() => Console.WriteLine("Baking for 25 minutes at 350 degrees.");

        public void Cut() => Console.WriteLine("Cutting the pizza.");

        public void Box() => Console.WriteLine("Putting pizza in a box.");
    }
}
