using Iterator;
using Iterator.Menus;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu[] menus = { new PancakeHouseMenu(), new DinerMenu(), new CafeMenu() };
            Waiter waiter = new Waiter(menus);

            waiter.PrintMenu();
        }
    }
}
