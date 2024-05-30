namespace AbstractFactoryPaymentSystem.Products.PayPal
{
    internal class PayPalAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"PayPal payment authorized for {amount}");
            return true;
        }
    }
}
