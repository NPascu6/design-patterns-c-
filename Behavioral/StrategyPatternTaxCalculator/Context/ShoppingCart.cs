using StrategyPatternTaxCalculator.Strategies;

namespace StrategyPatternTaxCalculator.Context
{
    internal class ShoppingCart
    {
        private readonly ITaxStrategy _taxStrategy;
        private double _purchaseAmount;

        public ShoppingCart(ITaxStrategy taxStrategy, double purchaseAmount)
        {
            _taxStrategy = taxStrategy;
            _purchaseAmount = purchaseAmount;
        }

        public double Checkout()
        {
            double tax = _taxStrategy.CalculateTax(_purchaseAmount);
            return _purchaseAmount + tax;
        }
    }
}
