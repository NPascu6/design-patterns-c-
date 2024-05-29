using StructuralPizza;

Pizza pizza = new Pizza();
Console.WriteLine(pizza.MakePizza());

PizzaDecorator pizzaDecorator = new ChickenPizza(pizza);
Console.WriteLine(pizzaDecorator.MakePizza());

pizzaDecorator = new VeggiePizza(pizza);
Console.WriteLine(pizzaDecorator.MakePizza());
