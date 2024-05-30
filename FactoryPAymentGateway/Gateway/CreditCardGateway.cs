namespace FactoryPaymentGateway.Gateway
{
    internal class CreditCardGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment with Credit Card Gateway");
        }
    }
}
