namespace CommandPattern.Invoker
{
    internal class MenuOptions
    {
        private ICommand _openCommand;
        private ICommand _closeCommand;
        private ICommand _saveCommand;

        public MenuOptions(ICommand openCommand, ICommand closeCommand, ICommand saveCommand)
        {
            _openCommand = openCommand;
            _closeCommand = closeCommand;
            _saveCommand = saveCommand;
        }

        public void ClickOpen()
        {
            _openCommand.Execute();
        }

        public void ClickClose()
        {
            _closeCommand.Execute();
        }

        public void ClickSave()
        {
            _saveCommand.Execute();
        }

        public void ClickUndoSave()
        {
            _saveCommand.Undo();
        }

        public void ClickUndoOpen()
        {
            _openCommand.Undo();
        }

        public void ClickUndoClose()
        {
            _closeCommand.Undo();
        }

        public void ClickRedoOpen()
        {
            _openCommand.Redo();
        }

        public void ClickRedoClose()
        {
            _closeCommand.Redo();
        }

        public void ClickRedoSave()
        {
            _saveCommand.Redo();
        }
    }
}
