using StrategyPatternPaymentSystem.Context;
using StrategyPatternPaymentSystem.Strategy;

double purchaseAmount = 100;

IPaymentStrategy paymentMethod = new CreditCardPayment("1234567890123456", "12/25", "123");
Checkout checkout = new Checkout(paymentMethod);
checkout.CompletePayment(purchaseAmount);

Console.WriteLine();

paymentMethod = new PaypalPayment("test@test.com");
checkout = new Checkout(paymentMethod);
checkout.CompletePayment(purchaseAmount);

Console.WriteLine();

paymentMethod = new CryptoPayment("asdasd-123123qasdas-adasdas", "@#!@#541231!");
checkout = new Checkout(paymentMethod);
checkout.CompletePayment(purchaseAmount);

Console.ReadKey();