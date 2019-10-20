using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private IObservable Observable { get; set; }
        private double Temperature { get; set; }
        private double Humidity { get; set; }

        public CurrentConditionsDisplay(IObservable observable)
        {
            this.Observable = observable;
            observable.registerObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {this.Temperature}F degrees and {this.Humidity}% humidity");
        }
    }
}
