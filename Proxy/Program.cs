using State;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine("Seattle", 5);
            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMonitor.Report();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMonitor.Report();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            gumballMonitor.Report();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            gumballMonitor.Report();

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMonitor.Report();

            gumballMachine.Refill(10);

            gumballMonitor.Report();
        }
    }
}
