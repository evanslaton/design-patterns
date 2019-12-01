using System;

namespace Iterator
{
    public class Waiter
    {
        PancakeHouseMenu PancakeHouseMenu { get; }
        DinerMenu DinerMenu { get; }

        public Waiter(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = PancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = DinerMenu.CreateIterator();

            PrintMenu(pancakeIterator);
            Console.WriteLine();
            PrintMenu(dinerIterator);
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
