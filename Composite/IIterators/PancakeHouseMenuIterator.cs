using System;
using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> MenuItems { get; }
        int Index { get; set; }

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
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

        public bool HasNext() => Index == MenuItems.Count ? false : true;
    }
}
