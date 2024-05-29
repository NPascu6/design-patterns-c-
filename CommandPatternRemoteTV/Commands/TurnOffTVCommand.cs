using CommandPatternRemoteTV.Receiver;

namespace CommandPatternRemoteTV.Commands
{
    internal class TurnOffTVCommand : ICommand
    {
        private readonly Television _television;

        public TurnOffTVCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOff();
        }

        public void Undo()
        {
            _television.TurnOn();
        }
    }
}
