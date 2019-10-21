using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private HashSet<IObserver> Observers { get; }
        private double Temperature { get; set; }
        private double Humidity { get; set; }
        private double Pressure { get; set; }

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

        public void notifyObserver()
        {
            foreach (IObserver observer in this.Observers)
            {
                observer.Update(this.Temperature, this.Humidity, this.Pressure);
            }
        }

        public void MeasurementsChange()
        {
            this.notifyObserver();
        }

        public void setMeasurements(double temperature, double humidity, double pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.MeasurementsChange();
        }
    }
}
