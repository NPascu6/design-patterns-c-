namespace StrategyPatternPaymentSystem.Strategy
{
    internal class PaypalPayment : IPaymentStrategy
    {
        private readonly string _email;

        public PaypalPayment(string email)
        {
            _email = email;
        }

        public bool ProcessPayment(double amount)
        {
            // Process payment using Paypal
            Console.WriteLine($"Processing payment using Paypal with email {_email}, for the price of {amount}");
            return true;
        }
    }
}
