using AbstractFactoryPaymentSystem.Products;
using AbstractFactoryPaymentSystem.Products.PayPal;

namespace AbstractFactoryPaymentSystem.Factory
{
    internal class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreatePaymentAuthorization()
        {
            return new PayPalAuthorization();
        }

        public IPaymentTransfer CreatePaymentTransfer()
        {
            return new PayPalTransfer();
        }
    }
}
