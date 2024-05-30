using AbstractFactoryPaymentSystem.Products;

namespace AbstractFactoryPaymentSystem.Factory
{
    internal interface IPaymentFactory
    {
        IPaymentTransfer CreatePaymentTransfer();
        IPaymentAuthorization CreatePaymentAuthorization();
    }
}
