using System;

namespace State.States
{
    class SoldState : IState
    {

        public GumballMachine GumballMachine { get; set; }

        public SoldState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter() => Console.WriteLine("Please wait, we're already giving you a gumball");

        public void EjectQuarter() => Console.WriteLine("Sorry, you already turned the crank");

        public void TurnCrank() => Console.WriteLine("Turning twice doesn't get you another gumball!");

        public void Dispense()
        {
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count > 0)
            {
                GumballMachine.State = GumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                GumballMachine.State = GumballMachine.SoldOutState;
            }
        }

        public void Refill(int numberOfGumballs) => Console.WriteLine("I'm not empty!");
    }
}
