namespace StrategyPatternPaymentSystem.Strategy
{
    internal interface IPaymentStrategy
    {
        bool ProcessPayment(double amount);
    }
}
