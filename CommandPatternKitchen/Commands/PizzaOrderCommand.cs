

using CommandPatternKitchen.Receiver;

namespace CommandPatternKitchen.Commands
{
    internal class PizzaOrderCommand : ICommand
    {
        private readonly Kitchen _kitchen;

        public PizzaOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }

        public void Execute()
        {
            _kitchen.PreparePizza();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing Pizza Order...");
        }
    }
}
