using CommandPatternRemoteTV;
using CommandPatternRemoteTV.Commands;
using CommandPatternRemoteTV.Invoker;
using CommandPatternRemoteTV.Receiver;

Television tv = new Television();

ICommand turnOn = new TurnOnTVCommand(tv);
ICommand turnOff = new TurnOffTVCommand(tv);
ICommand volumeUp = new VolumeUpCommand(tv);
ICommand volumeDown = new VolumeDownCommand(tv);

RemoteControll remote = new RemoteControll();

remote.SetCommand(turnOn);
remote.PressButton();
remote.PressUndoButton();

Console.WriteLine();

remote.SetCommand(volumeUp);
remote.PressButton();
remote.PressUndoButton();

Console.WriteLine();

remote.SetCommand(volumeDown);
remote.PressButton();
remote.PressUndoButton();

Console.WriteLine();

remote.SetCommand(turnOff);
remote.PressButton();
remote.PressUndoButton();

Console.WriteLine();

Console.ReadKey();
