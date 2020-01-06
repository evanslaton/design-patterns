using System;

namespace State.States
{
    class SoldOutState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public SoldOutState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter() => Console.WriteLine("You can’t insert a quarter, the machine is sold out");

        public void EjectQuarter() => Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");

        public void TurnCrank() => Console.WriteLine("You turned, but there are no gumball");

        public void Dispense() => Console.WriteLine("No gumball dispense");

        public void Refill(int numberOfGumballs)
        {
            GumballMachine.Count = numberOfGumballs;
            Console.WriteLine($"Added {GumballMachine.Count} gumballs");
            GumballMachine.State = GumballMachine.NoQuarterState;
        }
    }
}
