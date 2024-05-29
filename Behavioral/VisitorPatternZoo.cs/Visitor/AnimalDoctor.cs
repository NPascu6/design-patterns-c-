using VisitorPatternZoo.cs.Elements;

namespace VisitorPatternZoo.cs.Visitor
{
    internal class AnimalDoctor : IVisitor
    {
        public void Visit(Lion lion)
        {
            Console.WriteLine("Lion checkup");
        }

        public void Visit(Monkey monkey)
        {
            Console.WriteLine("Monkey checkup");
        }

        public void Visit(Bear bear)
        {
            Console.WriteLine("Bear checkup");
        }

        public void Visit(Giraffe giraffe)
        {
            Console.WriteLine("Giraffe checkup");
        }
    }
}
