using StrategyPatternTaxCalculator.Context;
using StrategyPatternTaxCalculator.Strategies;

double purchaseAmount = 100;

ShoppingCart shoppingCart = new ShoppingCart(new USTaxStrategy(), purchaseAmount);
double totalAmount = shoppingCart.Checkout();
Console.WriteLine($"Total amount with US tax: {totalAmount}");

shoppingCart = new ShoppingCart(new UKTaxStrategy(), purchaseAmount);
totalAmount = shoppingCart.Checkout();
Console.WriteLine($"Total amount with UK tax: {totalAmount}");

shoppingCart = new ShoppingCart(new CHTaxStrategy(), purchaseAmount);
totalAmount = shoppingCart.Checkout();
Console.WriteLine($"Total amount with CH tax: {totalAmount}");

shoppingCart = new ShoppingCart(new ROTaxStrategy(), purchaseAmount);
totalAmount = shoppingCart.Checkout();
Console.WriteLine($"Total amount with RO tax: {totalAmount}");

Console.ReadKey();
