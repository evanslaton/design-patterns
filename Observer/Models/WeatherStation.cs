using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private HashSet<IObserver> Observers { get; }
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherStation()
        {
            this.Observers = new HashSet<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void setMeasurements(double temperature, double humidity, double pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.MeasurementsChange();
        }

        public void MeasurementsChange()
        {
            this.notifyObserver();
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in this.Observers)
            {
                observer.Update();
            }
        }
    }
}
