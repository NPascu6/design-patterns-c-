using ObserverPatternMonitorinSystem.ObserverInterface;

namespace ObserverPatternMonitorinSystem.Observer
{
    internal class AdminTeam : IObserver
    {
        public void Update(string serverName, string status)
        {
            Console.WriteLine($"Admin Team alert: server {serverName} is {status}");
        }
    }
}
