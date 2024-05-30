namespace AbstractFactoryPaymentSystem.Products.PayPal
{
    internal class PayPalTransfer : IPaymentTransfer
    {
        public bool TransferPayment(decimal amount)
        {
            Console.WriteLine($"PayPal payment transferred for {amount}");
            return true;
        }
    }
}
