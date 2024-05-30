namespace AbstractFactoryPaymentSystem.Products
{
    internal interface IPaymentTransfer
    {
        bool TransferPayment(decimal amount);
    }
}
