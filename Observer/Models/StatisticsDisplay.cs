using System;

namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private IObservable Observable { get; set; }
        private double TemperaturesSum { get; set; }
        private double NumberOfTemperatures { get; set; }
        private double MaximumTemperature { get; set; }
        private double MinimumTemperature { get; set; }

        public StatisticsDisplay(IObservable observable)
        {
            this.Observable = observable;
            observable.registerObserver(this);
            this.TemperaturesSum = 0;
            this.NumberOfTemperatures = 0;
            this.MaximumTemperature = Int32.MinValue;
            this.MinimumTemperature = Int32.MaxValue;
        }

        public void Update()
        {
            if (this.Observable is WeatherStation weatherStation)
            {
                this.TemperaturesSum += weatherStation.Temperature;
                this.NumberOfTemperatures++;
                if (weatherStation.Temperature > this.MaximumTemperature) 
                    this.MaximumTemperature = weatherStation.Temperature;
                if (weatherStation.Temperature < this.MinimumTemperature) 
                    this.MinimumTemperature = weatherStation.Temperature;
            }
            this.Display();
        }

        public double CalculateAverage()
        {
            return this.TemperaturesSum / this.NumberOfTemperatures;
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {this.CalculateAverage()}/{this.MaximumTemperature}/{this.MinimumTemperature}");
        }
    }
}
