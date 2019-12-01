using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            Waiter waiter = new Waiter(pancakeHouseMenu, dinerMenu);

            waiter.PrintMenu();
        }
    }
}
