using State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class GumballMonitor
    {
        public GumballMachine GumballMachine { get; set; }

        public GumballMonitor(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {GumballMachine.Location}");
            Console.WriteLine($"Current Inventory: {GumballMachine.Count} gumballs");
            Console.WriteLine($"Current State: {GumballMachine.State}\n");
        }
    }
}
