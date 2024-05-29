

using ObserverPatternMonitorinSystem.Observer;
using ObserverPatternMonitorinSystem.Subject;

var server = new Server("Server 1", "Active");

var adminTeam = new AdminTeam();
var itTeam = new ITTeam();

server.Attach(adminTeam);
server.Attach(itTeam);

Console.WriteLine("Server status: " + server.GetStatus() + "\n");

server.ChangeStatus("Inactive");

Console.WriteLine("Server status: " + server.GetStatus() + "\n");

server.Detach(itTeam);

server.ChangeStatus("Active");



Console.ReadKey();


