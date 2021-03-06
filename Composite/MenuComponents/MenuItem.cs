﻿using Composite;
using System;
using System.Collections;

namespace Iterator
{
    public class MenuItem : MenuComponent
    {
        public bool Vegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegetarian, double price) :
            base(name, description) 
        {
            Vegetarian = vegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.Write(Name);
            if (Vegetarian) Console.Write(" (v),");
            Console.WriteLine($" {Price} -- {Description}");
        }

        public override IEnumerator CreateEnumerator() => new NullEnumerator();
    }
}
