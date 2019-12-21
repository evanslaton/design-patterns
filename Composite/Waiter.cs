using Composite;
using Iterator.Menus;
using System;

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
    }
}
