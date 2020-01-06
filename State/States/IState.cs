namespace State
{
    interface IState
    {
        public void InsertQuarter();
        public void EjectQuarter();
        public void TurnCrank();
        public void Dispense();
        public void Refill(int numberOfGumballs);
    }
}
