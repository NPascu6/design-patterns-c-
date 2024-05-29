namespace StrategyPatternTaxCalculator.Strategies
{
    internal class USTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.07;
        }
    }
}
