namespace StrategyPatternTaxCalculator.Strategies
{
    internal class UKTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.2;
        }
    }
}
