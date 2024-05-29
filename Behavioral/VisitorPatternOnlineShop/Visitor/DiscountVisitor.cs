using VisitorPatternOnlineShop.Elements;

namespace VisitorPatternOnlineShop.Visitor
{
    internal class DiscountVisitor : IProductVisitor
    {
        public double DiscountedPrice { get; private set; } = 0;
        public void Visit(Book book)
        {
            DiscountedPrice = book.Price * 0.9;
        }

        public void Visit(Electronic electronic)
        {
            DiscountedPrice = electronic.Price *= 0.8;
        }

        public void Visit(Grocery grocery)
        {
            DiscountedPrice = grocery.Price *= 0.95;
        }
    }
}
