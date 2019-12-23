using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class Menu : MenuComponent
    {
        IEnumerator Enumerator { get; set; }
        public List<MenuComponent> MenuComponents { get; }

        public Menu(string name, string description) :
            base(name, description)
        {
            Enumerator = null;
            MenuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent) => 
            MenuComponents.Add(menuComponent);

        public override void Remove(MenuComponent menuComponent) =>
            MenuComponents.Remove(menuComponent);

        public override MenuComponent GetChild(int i) => MenuComponents[i];

        public override void Print()
        {
            Console.WriteLine($"\n{Name}, {Description}");
            Console.WriteLine("-----------------");
            IEnumerator<MenuComponent> menuComponents = MenuComponents.GetEnumerator();
            while (menuComponents.MoveNext())
            {
                MenuComponent menuComponent = menuComponents.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator CreateEnumerator()
        {
            if (Enumerator == null)
                Enumerator = new CompositeEnumerator(MenuComponents.GetEnumerator());
            return Enumerator;
        }
    }
}
