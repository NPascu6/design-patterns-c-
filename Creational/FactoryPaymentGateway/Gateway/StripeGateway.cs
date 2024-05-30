namespace FactoryPaymentGateway.Gateway
{
    internal class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment with Stripe Gateway");
        }
    }
}
