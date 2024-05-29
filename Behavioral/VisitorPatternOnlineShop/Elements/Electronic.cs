using VisitorPatternOnlineShop.Visitor;

namespace VisitorPatternOnlineShop.Elements
{
    internal class Electronic : IProduct
    {
        public double Price { get; set; }
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
