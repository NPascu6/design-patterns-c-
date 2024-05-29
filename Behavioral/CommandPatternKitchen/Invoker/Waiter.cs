namespace CommandPatternKitchen.Invoker
{
    internal class Waiter
    {
        private readonly List<ICommand> _orders = new List<ICommand>();

        public void TakerOrder(ICommand command)
        {
            _orders.Add(command);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}
