using FactoryPaymentGateway.Factory;
using FactoryPaymentGateway.Gateway;

start:

Console.WriteLine("Select payment gateway:");
Console.WriteLine("1. Credit Card");
Console.WriteLine("2. Stripe");
Console.WriteLine("3. PayPal");
Console.WriteLine("4. Exit");

var paymentGatewayName = Console.ReadLine();
if (paymentGatewayName == "4" || paymentGatewayName == 'Exit')
{
    Environment.Exit(0);
}

try
{
    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(paymentGatewayName);
    paymentGateway.ProcessPayment(100);
    goto start;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();
