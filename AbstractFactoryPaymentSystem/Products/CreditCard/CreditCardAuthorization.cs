namespace AbstractFactoryPaymentSystem.Products.CreditCard
{
    internal class CreditCardAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Credit card payment authorized for {amount}");
            return true;
        }
    }
}
