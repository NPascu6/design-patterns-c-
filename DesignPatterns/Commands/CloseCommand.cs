using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    internal class CloseCommand : ICommand
    {
        private Document _document;

        public CloseCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Close();
        }

        public void Undo()
        {
            _document.Open();
        }

        public void Redo()
        {
            _document.Close();
        }
    }
}
