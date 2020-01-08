using State.States;
using System;

namespace State
{
    class GumballMachine
    {
        public IState SoldOutState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState HasQuarterState { get; set; }
        public IState SoldState { get; set; }
        public IState WinnerState { get; set; }
        public IState State { get; set; }
        public int Count { get; set; }
        public string Location { get; set; }

        public GumballMachine(string location, int numberOfGumballs = 0)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            if (numberOfGumballs > 0) State = NoQuarterState;
            else State = SoldOutState;
            Location = location;

        }

        public void InsertQuarter() => State.InsertQuarter();

        public void EjectQuarter() => State.EjectQuarter();

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void Dispense() => State.Dispense();

        public void Refill(int numberOfGumballs) => State.Refill(numberOfGumballs);

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            if (Count != 0) Count = Count - 1;
        }

        public override string ToString() => $"State: {State}, Count: {Count}\n";
    }
}
