using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems { get; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();
            AddItem("Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        public IIterator CreateIterator() => new PancakeHouseMenuIterator(MenuItems);
    }
}
