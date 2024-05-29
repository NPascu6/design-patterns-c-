using ObserverPatternMonitorinSystem.ObserverInterface;

namespace ObserverPatternMonitorinSystem.Observer
{
    internal class ITTeam : IObserver
    {
        public void Update(string serverName, string status)
        {
            Console.WriteLine($"IT Team alert: server {serverName} is {status}");
        }
    }
}
