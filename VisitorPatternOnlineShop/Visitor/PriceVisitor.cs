using VisitorPatternOnlineShop.Elements;

namespace VisitorPatternOnlineShop.Visitor
{
    internal class PriceVisitor : IProductVisitor
    {
        public double Price { get; set; } = 0;

        public void Visit(Book book)
        {
            Price = book.Price;
        }

        public void Visit(Electronic electronic)
        {
            Price = electronic.Price;
        }

        public void Visit(Grocery grocery)
        {
            Price = grocery.Price;
        }
    }
}
