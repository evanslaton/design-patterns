namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherStation);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherStation);
            weatherStation.setMeasurements(80, 65, 30.4);
            weatherStation.setMeasurements(82, 70, 29.2);
            weatherStation.setMeasurements(78, 90, 29.2);
        }
    }
}
