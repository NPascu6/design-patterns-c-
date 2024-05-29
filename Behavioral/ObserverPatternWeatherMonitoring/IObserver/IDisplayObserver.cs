namespace ObserverPatternWeatherMonitoring.IObserver
{
    internal interface IDisplayObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
