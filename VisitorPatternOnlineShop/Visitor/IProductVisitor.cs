using VisitorPatternOnlineShop.Elements;

namespace VisitorPatternOnlineShop.Visitor
{
    internal interface IProductVisitor
    {
        void Visit(Book book);
        void Visit(Electronic electronic);
        void Visit(Grocery grocery);
    }
}
