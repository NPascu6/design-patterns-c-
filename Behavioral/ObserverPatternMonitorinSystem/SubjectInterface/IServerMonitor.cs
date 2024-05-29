using ObserverPatternMonitorinSystem.ObserverInterface;

namespace ObserverPatternMonitorinSystem.SubjectInterface
{
    internal interface IServerMonitor
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string serverName, string status);
    }
}
