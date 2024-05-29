namespace StrategyPatternPaymentSystem.Strategy
{
    internal class CryptoPayment : IPaymentStrategy
    {
        private readonly string _cryptoAddress;
        private readonly string _cryptoKey;

        public CryptoPayment(string cryptoAddress, string cryptoKey)
        {
            _cryptoAddress = cryptoAddress;
            _cryptoKey = cryptoKey;
        }

        public bool ProcessPayment(double amount)
        {
            // Process payment using crypto
            Console.WriteLine($"Processing payment using crypto with address {_cryptoAddress}, key {_cryptoKey}, for the price of {amount}");
            return true;
        }
    }
}
