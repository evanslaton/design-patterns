using System;

namespace Facade
{
    class PopcornPopper
    {
        public void On() => Console.WriteLine("Popcorn popper is on");
        public void Off() => Console.WriteLine("Popcorn popper is off");
        public void Pop() => Console.WriteLine("Popcorn is popped");
    }
}
