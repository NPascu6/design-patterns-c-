namespace FactoryPaymentGateway.Gateway
{
    internal class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment with PayPal Gateway");
        }
    }
}
