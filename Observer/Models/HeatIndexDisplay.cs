using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private IObservable Observable { get; set; }

        public HeatIndexDisplay(IObservable observable)
        {
            this.Observable = observable;
            observable.registerObserver(this);
        }

        public void Update()
        {
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {this.ComputeHeatIndex()}");
        }

        private double ComputeHeatIndex()
        {
            double heatIndex = 0.0;

            if (this.Observable is WeatherStation weatherStation)
            {
                double temperature = weatherStation.Temperature;
                double humidity = weatherStation.Humidity;
                heatIndex = ((16.923 + (0.185212 * temperature) + (5.37941 * humidity) - 
                    (0.100254 * temperature * humidity) + (0.00941695 * (temperature * temperature)) + 
                    (0.00728898 * (humidity * humidity)) + (0.000345372 * (temperature * temperature * humidity)) - 
                    (0.000814971 * (temperature * humidity * humidity)) + 
                    (0.0000102102 * (temperature * temperature * humidity * humidity)) - 
                    (0.000038646 * (temperature * temperature * temperature)) + 
                    (0.0000291583 * (humidity * humidity * humidity)) + 
                    (0.00000142721 * (temperature * temperature * temperature * humidity)) +
                    (0.000000197483 * (temperature * humidity * humidity * humidity)) - 
                    (0.0000000218429 * (temperature * temperature * temperature * humidity * humidity)) +
                    0.000000000843296 * (temperature * temperature * humidity * humidity * humidity)) -
                    (0.0000000000481975 * (temperature * temperature * temperature * humidity * humidity * humidity)));
            }
            return heatIndex;
        }
    }
}
