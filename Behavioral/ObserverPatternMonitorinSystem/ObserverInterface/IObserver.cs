namespace ObserverPatternMonitorinSystem.ObserverInterface
{
    internal interface IObserver
    {
        void Update(string serverName, string status);
    }
}
