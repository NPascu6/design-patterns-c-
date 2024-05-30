namespace AbstractFactoryPaymentSystem.Products
{
    internal interface IPaymentAuthorization
    {
        bool AuthorizePayment(decimal amount);
    }
}
