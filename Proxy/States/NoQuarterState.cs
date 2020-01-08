using System;

namespace State.States
{
    class NoQuarterState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public NoQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            GumballMachine.State = GumballMachine.HasQuarterState;
        }
        
        public void EjectQuarter() => Console.WriteLine("You haven't inserted a quarter");
        
        public void TurnCrank() => Console.WriteLine("You turned, but there's no quarter");
        
        public void Dispense() => Console.WriteLine("You need to pay first");

        public void Refill(int numberOfGumballs) => Console.WriteLine("I'm not empty!");
    }
}
