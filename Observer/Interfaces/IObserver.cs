namespace ObserverPattern
{
    public interface IObserver
    {
        public void Update(double temperature, double humity, double pressure);
    }
}
