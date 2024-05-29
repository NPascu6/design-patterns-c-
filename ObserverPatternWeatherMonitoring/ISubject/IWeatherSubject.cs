namespace ObserverPatternWeatherMonitoring.ISubject
{
    internal interface IWeatherSubject
    {
        void RegisterObserver(IObserver.IDisplayObserver observer);
        void RemoveObserver(IObserver.IDisplayObserver observer);
        void NotifyObservers();
    }
}
