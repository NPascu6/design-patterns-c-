using AbstractFactoryPaymentSystem.Factory;
using AbstractFactoryPaymentSystem.Products;

namespace AbstractFactoryPaymentSystem.Client
{
    internal class PaymentProcessor
    {
        private readonly IPaymentAuthorization _paymentAuthorization;
        private readonly IPaymentTransfer _paymentTransfer;

        public PaymentProcessor(IPaymentFactory paymentFactory)
        {
            _paymentAuthorization = paymentFactory.CreatePaymentAuthorization();
            _paymentTransfer = paymentFactory.CreatePaymentTransfer();
        }

        public bool ProcessPayment(decimal amount)
        {
            if (_paymentAuthorization.AuthorizePayment(amount))
            {
                return _paymentTransfer.TransferPayment(amount);
            }

            return false;
        }

        public bool CancelPayment(decimal amount)
        {
            return _paymentTransfer.TransferPayment(-amount);
        }

        public bool RefundPayment(decimal amount)
        {
            return _paymentTransfer.TransferPayment(amount);
        }
    }
}
