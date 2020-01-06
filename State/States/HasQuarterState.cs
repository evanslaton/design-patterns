using System;

namespace State.States
{
    class HasQuarterState : IState
    {
        Random RandomWinner { get; }
        public GumballMachine GumballMachine { get; set; }

        public HasQuarterState(GumballMachine gumballMachine)
        {
            RandomWinner = new Random();
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter() => Console.WriteLine("You can’t insert another quarter");

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.State = GumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = RandomWinner.Next(10);
            if (winner == 0 && GumballMachine.Count > 1)
            {
                GumballMachine.State = GumballMachine.WinnerState;
            }
            else
            {
                GumballMachine.State = GumballMachine.SoldState;
            }
        }

        public void Dispense() => Console.WriteLine("No gumball dispensed");

        public void Refill(int numberOfGumballs) => Console.WriteLine("I'm not empty!");
    }
}
