using Iterator;
using Iterator.Menus;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with marinara sauce", true, 3.89));

            dinerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie", "Apples and cinnamon", true, 1.59));

            Waiter waiter = new Waiter(allMenus);

            waiter.PrintMenu();
        }
    }
}
