namespace CommandPatternRemoteTV.Commands
{
    internal class VolumeDownCommand : ICommand
    {
        private readonly Receiver.Television _television;

        public VolumeDownCommand(Receiver.Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.VolumeDown();
        }

        public void Undo()
        {
            _television.VolumeUp();
        }
    }
}
