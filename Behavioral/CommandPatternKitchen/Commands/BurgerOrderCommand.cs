using CommandPatternKitchen.Receiver;

namespace CommandPatternKitchen.Commands
{
    internal class BurgerOrderCommand : ICommand
    {
        private readonly Kitchen _kitchen;

        public BurgerOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }

        public void Execute()
        {
            _kitchen.PrepareBurger();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing Burger Order...");
        }
    }
}
