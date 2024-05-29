

using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

//Create the receiver
Document document = new Document();

//Create the commands
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);

//Create the invoker
MenuOptions menu = new MenuOptions(openCommand, closeCommand, saveCommand);

//Perform actions
Console.WriteLine("Open - close - open");

menu.ClickOpen();
menu.ClickUndoOpen();
menu.ClickRedoOpen();

Console.WriteLine();

Console.WriteLine("Save - undo - redo");

menu.ClickSave();
menu.ClickUndoSave();
menu.ClickRedoSave();

Console.WriteLine();

Console.WriteLine("Close - undo - redo");
menu.ClickClose();
menu.ClickUndoClose();
menu.ClickRedoClose();

Console.ReadKey();