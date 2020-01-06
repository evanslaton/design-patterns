using System;

namespace State.States
{
    class WinnerState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public WinnerState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter() => Console.WriteLine("You can’t insert a quarter at this time");

        public void EjectQuarter() => Console.WriteLine("Too late for that");

        public void TurnCrank() => Console.WriteLine("Too late for that");

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count == 0)
            {
                GumballMachine.State = GumballMachine.SoldOutState;
            }
            else
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
        }

        public void Refill(int numberOfGumballs) => Console.WriteLine("I'm not empty!");
    }
}
