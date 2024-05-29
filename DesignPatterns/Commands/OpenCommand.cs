using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    public class OpenCommand : ICommand
    {
        private Document _document;

        public OpenCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Open();
        }

        public void Undo()
        {
            _document.Close();
        }

        public void Redo()
        {
            _document.Open();
        }
    }
}
