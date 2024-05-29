namespace StrategyPatternPaymentSystem.Strategy
{
    internal class DirectBankTransfer : IPaymentStrategy
    {
        private readonly string _accountNumber;
        private readonly string _sortCode;

        public DirectBankTransfer(string accountNumber, string sortCode)
        {
            _accountNumber = accountNumber;
            _sortCode = sortCode;
        }

        public bool ProcessPayment(double amount)
        {
            // Process payment using direct bank transfer
            Console.WriteLine($"Processing payment using direct bank transfer with account number {_accountNumber}, sort code {_sortCode}, for the price of {amount}");
            return true;
        }
    }
}
