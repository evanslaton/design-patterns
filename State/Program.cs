using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            Console.WriteLine(gumballMachine);

            gumballMachine.Refill(10);

            Console.WriteLine(gumballMachine);
        }
    }
}
