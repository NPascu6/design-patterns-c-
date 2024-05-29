namespace StrategyPatternTaxCalculator.Strategies
{
    internal class CHTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.1;
        }
    }
}
