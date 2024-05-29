using ObserverPatternWeatherMonitoring.IObserver;

namespace ObserverPatternWeatherMonitoring.Observer
{
    internal class Forecast : IDisplayObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Forecast: {temperature}°C, {humidity}%, {pressure}hPa");
        }
    }
}
