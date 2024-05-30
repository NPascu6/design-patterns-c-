using AbstractFactoryPaymentSystem.Client;
using AbstractFactoryPaymentSystem.Factory;

Console.WriteLine("Processing payment using Credit Card:");
var creditCardFactory = new CreditCardPaymentFactory();
var creditCardProcessor = new PaymentProcessor(creditCardFactory);
creditCardProcessor.ProcessPayment(100.00M);

Console.WriteLine("\nProcessing payment using PayPal:");
var payPalFactory = new PayPalPaymentFactory();
var payPalProcessor = new PaymentProcessor(payPalFactory);
payPalProcessor.ProcessPayment(100.00M);

Console.ReadKey();