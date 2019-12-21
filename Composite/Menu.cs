using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Menu : MenuComponent
    {
        public List<MenuComponent> MenuComponents { get; }

        public Menu(string name, string description) :
            base(name, description)
        {
            MenuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent) => 
            MenuComponents.Add(menuComponent);

        public override void Remove(MenuComponent menuComponent) =>
            MenuComponents.Remove(menuComponent);

        public override MenuComponent GetChild(int i) => MenuComponents[i];

        public override void Print()
        {
            Console.WriteLine($"{Name}, {Description}");
            List<MenuComponent>.Enumerator menuComponents = MenuComponents.GetEnumerator();
            while (menuComponents.MoveNext())
            {
                MenuComponent menuComponent = menuComponents.Current;
                menuComponent.Print();
            }
        }
    }
}
