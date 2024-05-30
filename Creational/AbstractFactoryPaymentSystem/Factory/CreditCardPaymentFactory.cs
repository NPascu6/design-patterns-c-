using AbstractFactoryPaymentSystem.Products;
using AbstractFactoryPaymentSystem.Products.CreditCard;

namespace AbstractFactoryPaymentSystem.Factory
{
    internal class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreatePaymentAuthorization()
        {
            return new CreditCardAuthorization();
        }

        public IPaymentTransfer CreatePaymentTransfer()
        {
            return new CreditCardTransfer();
        }
    }
}
