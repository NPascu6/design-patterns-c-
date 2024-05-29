using CommandPatternRemoteTV.Receiver;

namespace CommandPatternRemoteTV.Commands
{
    internal class TurnOnTVCommand : ICommand
    {
        private readonly Television _television;

        public TurnOnTVCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOn();
        }

        public void Undo()
        {
            _television.TurnOff();
        }
    }
}
