using VisitorPatternZoo.cs.Elements;

namespace VisitorPatternZoo.cs.Visitor
{
    internal class Caretaker : IVisitor
    {
        public void Visit(Lion lion)
        {
            Console.WriteLine("Feeding Lion");
            Console.WriteLine("Washing Lion's cage");
        }

        public void Visit(Monkey monkey)
        {
            Console.WriteLine("Feeding Monkey");
            Console.WriteLine("Washing Monkey's cage");
        }

        public void Visit(Bear bear)
        {
            Console.WriteLine("Feeding Bear");
            Console.WriteLine("Washing Bear's cage");
        }

        public void Visit(Giraffe giraffe)
        {
            Console.WriteLine("Feeding Giraffe");
            Console.WriteLine("Washing Giraffe's cage");
        }
    }
}
