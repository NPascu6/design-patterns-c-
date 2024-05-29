using VisitorPatternOnlineShop.Elements;
using VisitorPatternOnlineShop.Visitor;

IProduct book = new Book
{
    Author = "J.K. Rowling",
    Price = 23.33,
    Title = "Harry Potter"
};

IProduct iphone = new Electronic
{
    Model = "iPhone 12",
    Brand = "Apple MAC",
    Price = 999.99
};

IProduct milk = new Grocery
{
    Name = "Milk Dayri",
    Price = 2.99,
    ExpiryDate = DateTime.Now.AddDays(7)
};

var descriptionVisitor = new DescriptionVisitor();
var discountVisitor = new DiscountVisitor();
var priceVisitor = new PriceVisitor();

book.Accept(descriptionVisitor);
book.Accept(priceVisitor);
Console.WriteLine($"Book price before discount: {priceVisitor.Price}");
book.Accept(discountVisitor);
Console.WriteLine($"Book price after discount: {discountVisitor.DiscountedPrice}");

iphone.Accept(descriptionVisitor);
iphone.Accept(priceVisitor);

Console.WriteLine($"iPhone price before discount: {priceVisitor.Price}");
iphone.Accept(discountVisitor);
Console.WriteLine($"iPhone price after discount: {discountVisitor.DiscountedPrice}");

milk.Accept(descriptionVisitor);
milk.Accept(priceVisitor);

Console.WriteLine($"milk price before discount: {priceVisitor.Price}");
milk.Accept(discountVisitor);
Console.WriteLine($"milk price after discount: {discountVisitor.DiscountedPrice}");


Console.ReadKey();
