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
            IEnumerator iterator = AllMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Current;
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
