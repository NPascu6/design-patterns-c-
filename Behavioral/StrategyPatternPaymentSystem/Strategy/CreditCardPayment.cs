namespace StrategyPatternPaymentSystem.Strategy
{
    internal class CreditCardPayment : IPaymentStrategy
    {
        private readonly string _cardNumber;
        private readonly string _cvv;
        private readonly string _expiryDate;

        public CreditCardPayment(string cardNumber, string cvv, string expiryDate)
        {
            _cardNumber = cardNumber;
            _cvv = cvv;
            _expiryDate = expiryDate;
        }

        public bool ProcessPayment(double amount)
        {
            // Process payment using credit card
            Console.WriteLine($"Processing payment using credit card with card number {_cardNumber}, cvv {_cvv}, and expiry date {_expiryDate}, for the price of {amount}");
            return true;
        }
    }
}
