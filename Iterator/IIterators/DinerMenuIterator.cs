using System;

namespace Iterator
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] MenuItems { get; }
        int Index { get; set; }

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            MenuItems = menuItems;
            Index = 0;
        }

        public Object Next()
        {
            MenuItem menuItem = MenuItems[Index];
            Index += 1;
            return menuItem;
        }

        public bool HasNext()
        {
            if (Index >= MenuItems.Length || MenuItems[Index] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
