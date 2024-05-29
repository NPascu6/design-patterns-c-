using CommandPatternRemoteTV.Receiver;

namespace CommandPatternRemoteTV.Commands
{
    internal class VolumeUpCommand : ICommand
    {
        private readonly Television _television;

        public VolumeUpCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.VolumeUp();
        }

        public void Undo()
        {
            _television.VolumeDown();
        }
    }
}
