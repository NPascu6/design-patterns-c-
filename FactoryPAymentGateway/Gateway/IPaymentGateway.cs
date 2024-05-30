namespace FactoryPaymentGateway.Gateway
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
