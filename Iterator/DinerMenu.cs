using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class DinerMenu
    {
        public static int MAX_ITEMS = 6;
        public int NumberOfItems { get; set; }
        MenuItem[] MenuItems { get; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT", "Fakin\' with lettuce and tomato", true, 2.99);
            AddItem("BLT", "Bacon with lettuc and tomato", false, 2.99);
            AddItem("Soup of the day", "Soup with a side of potato salade", false, 3.29);
        }

        public void AddItem(string name, string description,
                    bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (NumberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu.");
            }
            else
            {
                MenuItems[NumberOfItems] = menuItem;
                NumberOfItems++;
            }
        }
    }
}
