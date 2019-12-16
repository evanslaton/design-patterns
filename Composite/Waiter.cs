using Iterator.Menus;
using System;

namespace Iterator
{
    public class Waiter
    {
        IMenu[] Menus;

        public Waiter(IMenu[] menus)
        {
            Menus = menus;
        }

        public void PrintMenu()
        {
            foreach (IMenu menu in Menus)
            {
                PrintMenu(menu.CreateIterator());
                Console.WriteLine();
            }
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Price} - {menuItem.Name}: {menuItem.Description}");
            }
        }
    }
}
