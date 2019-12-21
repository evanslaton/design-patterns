﻿using System;

namespace Composite
{
    public abstract class MenuComponent
    {
        public string Name { get; }
        public string Description { get; }

        public MenuComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Add(MenuComponent menuComponent) => throw new NotSupportedException();

        public virtual void Remove(MenuComponent menuComponent) => throw new NotSupportedException();

        public virtual MenuComponent GetChild(int i) => throw new NotSupportedException();

        public virtual string GetName() => throw new NotSupportedException();

        public virtual double GetPrice() => throw new NotSupportedException();

        public virtual bool IsVegetarian() => throw new NotSupportedException();

        public virtual void Print() => throw new NotSupportedException();
    }
}
