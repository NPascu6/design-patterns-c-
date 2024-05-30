using FactoryPaymentGateway.Gateway;

namespace FactoryPaymentGateway.Factory
{
    internal class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string paymentGateway)
        {
            return paymentGateway switch
            {
                "CreditCard" => new CreditCardGateway(),
                "Stripe" => new StripeGateway(),
                "PayPal" => new PayPalGateway(),
                _ => throw new ArgumentException("Invalid payment gateway", nameof(paymentGateway)),
            };
        }
    }
}
