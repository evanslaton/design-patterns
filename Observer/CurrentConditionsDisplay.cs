using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private Observable Observable { get; set; }
        private double Temperature { get; set; }
        private double Humidity { get; set; }

        public CurrentConditionsDisplay(Observable observable)
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
