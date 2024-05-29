using StrategyPatternPaymentSystem.Strategy;

namespace StrategyPatternPaymentSystem.Context
{
    internal class Checkout
    {
        private readonly IPaymentStrategy _paymentMethod;

        public Checkout(IPaymentStrategy paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public bool CompletePayment(double amount)
        {
            return _paymentMethod.ProcessPayment(amount);
        }
    }
}
