using Composite;
using System;
using System.Collections;

namespace Iterator
{
    public class Waiter
    {
        MenuComponent AllMenus { get; }

        public Waiter(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void PrintMenu() => AllMenus.Print();

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = AllMenus.CreateEnumerator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (((MenuItem)menuComponent).Vegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException exception) { }
            }
        }
    }
}
