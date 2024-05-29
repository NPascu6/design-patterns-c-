namespace CommandPatternKitchen
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
