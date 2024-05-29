using ObserverPatternWeatherMonitoring.IObserver;
using ObserverPatternWeatherMonitoring.ISubject;

namespace ObserverPatternWeatherMonitoring.Subject
{
    internal class WeatherStation : IWeatherSubject
    {
        private readonly List<IDisplayObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherStation()
        {
            _observers = new List<IDisplayObserver>();
        }

        public void RegisterObserver(IDisplayObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IDisplayObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void WeatherDataChanged()
        {
            NotifyObservers();
        }

        public void SetWeatherData(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            WeatherDataChanged();
        }
    }
}
