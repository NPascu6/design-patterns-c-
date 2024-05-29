using CommandPatternKitchen;
using CommandPatternKitchen.Commands;
using CommandPatternKitchen.Invoker;
using CommandPatternKitchen.Receiver;

Kitchen kitchen = new Kitchen();

ICommand burgerOrder = new BurgerOrderCommand(kitchen);
ICommand pizzaOrder = new PizzaOrderCommand(kitchen);
ICommand pastaOrder = new PastaOrderCommand(kitchen);

Waiter waiter = new Waiter();

waiter.TakerOrder(burgerOrder);
waiter.TakerOrder(pizzaOrder);
waiter.TakerOrder(pastaOrder);

waiter.PlaceOrders();

Console.WriteLine("Orders are ready!");

Console.WriteLine("\nUndoing Orders...");

burgerOrder.Undo();
pizzaOrder.Undo();
pastaOrder.Undo();

Console.ReadLine();
