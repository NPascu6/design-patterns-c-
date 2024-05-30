namespace AbstractFactoryPaymentSystem.Products.CreditCard
{
    internal class CreditCardTransfer : IPaymentTransfer
    {
        public bool TransferPayment(decimal amount)
        {
            Console.WriteLine($"Credit card payment transferred for {amount}");
            return true;
        }
    }
}
