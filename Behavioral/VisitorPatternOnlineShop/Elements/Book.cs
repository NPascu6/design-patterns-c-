using VisitorPatternOnlineShop.Visitor;

namespace VisitorPatternOnlineShop.Elements
{
    internal class Book : IProduct
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
