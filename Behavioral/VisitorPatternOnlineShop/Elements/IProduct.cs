using VisitorPatternOnlineShop.Visitor;

namespace VisitorPatternOnlineShop.Elements
{
    internal interface IProduct
    {
        void Accept(IProductVisitor visitor);
    }
}
