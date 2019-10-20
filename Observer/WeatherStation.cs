using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : Observable
    {
        private HashSet<Observer> Observers { get; }
        private double Temperature { get; set; }
        private double Humidity { get; set; }
        private double Pressure { get; set; }

        public WeatherStation()
        {
            this.Observers = new HashSet<Observer>();
        }

        public void registerObserver(Observer observer)
        {
            this.Observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            this.Observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (Observer observer in this.Observers)
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
