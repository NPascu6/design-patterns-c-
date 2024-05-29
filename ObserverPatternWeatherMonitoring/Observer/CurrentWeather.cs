using ObserverPatternWeatherMonitoring.IObserver;

namespace ObserverPatternWeatherMonitoring.Observer
{
    internal class CurrentWeather : IDisplayObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Current weather: {temperature}°C, {humidity}%, {pressure}hPa");
        }
    }
}
