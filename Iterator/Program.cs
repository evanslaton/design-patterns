using Iterator.Menus;

namespace Iterator
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
