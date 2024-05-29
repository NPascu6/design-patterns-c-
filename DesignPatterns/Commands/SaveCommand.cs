using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    internal class SaveCommand : ICommand
    {
        private Document _document;

        public SaveCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Save();
        }

        public void Undo()
        {
            _document.Delete();
        }

        public void Redo()
        {
            _document.Save();
        }
    }
}
