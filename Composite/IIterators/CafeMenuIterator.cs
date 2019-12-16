using System.Collections.Generic;
using System.Linq;

namespace Iterator.IIterators
{
    public class CafeMenuIterator : IIterator
    {
        MenuItem[] MenuItems { get; }
        int Index { get; set; }

        public CafeMenuIterator(Dictionary<string, MenuItem> menuItems)
        {
            MenuItems = menuItems.Values.ToArray();
            Index = 0;
        }

        public object Next()
        {
            MenuItem menuItem = MenuItems[Index];
            Index += 1;
            return menuItem;
        }
        public bool HasNext() => Index == MenuItems.Length ? false : true;
    }
}
