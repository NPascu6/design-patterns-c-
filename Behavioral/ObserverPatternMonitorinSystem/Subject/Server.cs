using ObserverPatternMonitorinSystem.ObserverInterface;
using ObserverPatternMonitorinSystem.SubjectInterface;

namespace ObserverPatternMonitorinSystem.Subject
{
    internal class Server : IServerMonitor
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly string _serverName;
        private string _status;

        public Server(string serverName, string status)
        {
            _serverName = serverName;
            _status = status;
        }

        public void ChangeStatus(string status)
        {
            _status = status;
            Notify(_serverName, _status);
        }

        public string GetStatus()
        {
            return _status;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string serverName, string status)
        {
            foreach (var observer in _observers)
            {
                observer.Update(_serverName, _status);
            }
        }
    }
}
