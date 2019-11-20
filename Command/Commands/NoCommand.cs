using System;

namespace Command
{
    class NoCommand : Command
    {
        public void Execute() => Console.WriteLine("No command, do nothing");
        public void Undo() => Console.WriteLine("No command, do nothing");
    }
}
