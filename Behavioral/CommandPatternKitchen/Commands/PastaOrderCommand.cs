using CommandPatternKitchen.Receiver;

namespace CommandPatternKitchen.Commands
{
    internal class PastaOrderCommand : ICommand
    {
        private readonly Kitchen _kitchen;

        public PastaOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }

        public void Execute()
        {
            _kitchen.PreparePasta();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing Pasta Order...");
        }
    }
}
