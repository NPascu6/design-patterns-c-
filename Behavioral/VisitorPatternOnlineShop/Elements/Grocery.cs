using VisitorPatternOnlineShop.Visitor;

namespace VisitorPatternOnlineShop.Elements
{
    internal class Grocery : IProduct
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public DateTime ExpiryDate { get; set; }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
