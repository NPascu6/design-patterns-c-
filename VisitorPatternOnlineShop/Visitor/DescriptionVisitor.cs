using VisitorPatternOnlineShop.Elements;

namespace VisitorPatternOnlineShop.Visitor
{
    internal class DescriptionVisitor : IProductVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"\nBook: {book.Title} by {book.Author}");
        }

        public void Visit(Electronic electronic)
        {
            Console.WriteLine($"\nElectronic: {electronic.Brand}");
        }

        public void Visit(Grocery grocery)
        {
            Console.WriteLine($"\nGrocery: {grocery.Name}");
        }
    }
}
