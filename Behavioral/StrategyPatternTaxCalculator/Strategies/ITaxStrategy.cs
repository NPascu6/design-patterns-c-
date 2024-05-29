namespace StrategyPatternTaxCalculator.Strategies
{
    internal interface ITaxStrategy
    {
        double CalculateTax(double amount);
    }
}
