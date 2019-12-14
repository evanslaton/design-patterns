using Iterator.IIterators;
using System.Collections.Generic;

namespace Iterator.Menus
{
    public class CafeMenu : IMenu
    {
        Dictionary<string, MenuItem> MenuItems { get; set; }

        public CafeMenu()
        {
            MenuItems = new Dictionary<string, MenuItem>();
            AddItem("Veggie burger", "Whole wheat bun, lettuce," +
                    "tomato and a side of fries", true, 3.99);
            AddItem("Soup of the Day", "Served with a side salad", true, 2.99);
            AddItem("Burrito", "Beans, salsa and guacamole", true, 3.99);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem.Name, menuItem);
        }

        public IIterator CreateIterator() => new CafeMenuIterator(MenuItems);
    }
}
