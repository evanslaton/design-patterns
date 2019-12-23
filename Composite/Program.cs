using Iterator;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            pancakeHouseMenu.Add(new MenuItem("Pancake Breakfast", "Pancakes, scrambled eggs and toast", true, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes with blueberries", true, 3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with strawberries", true, 3.59));


            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(new MenuItem("Vegetarian BLT", "Fakin\' with lettuce and tomato", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuc and tomato", false, 2.99));
            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with marinara sauce", true, 3.89));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup with a side of potato salade", false, 3.29));

            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(new MenuItem("Veggie burger", "Whole wheat bun, lettuce, tomato and fries", true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the Day", "Served with a side salad", true, 2.99));
            cafeMenu.Add(new MenuItem("Burrito", "Beans, salsa and guacamole", true, 3.99));

            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            dessertMenu.Add(new MenuItem("Apple Pie", "Apples and cinnamon", true, 1.59));

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            dinerMenu.Add(dessertMenu);

            Waiter waiter = new Waiter(allMenus);

            //waiter.PrintMenu();

            waiter.PrintVegetarianMenu();
        }
    }
}
