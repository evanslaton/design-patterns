using Composite;
using System;

namespace Iterator
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool vegetarian, double price) :
            base(name, description, vegetarian, price) { }

        public override void Print()
        {
            Console.Write(Name);
            if (Vegetarian) Console.Write(" (v), ");
            Console.Write($"{Price} -- {Description}");
        }
    }
}
