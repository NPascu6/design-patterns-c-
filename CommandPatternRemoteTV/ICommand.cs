namespace CommandPatternRemoteTV
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
