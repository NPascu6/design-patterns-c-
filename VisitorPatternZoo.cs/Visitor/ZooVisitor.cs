using VisitorPatternZoo.cs.Elements;

namespace VisitorPatternZoo.cs.Visitor
{
    internal class ZooVisitor : IVisitor
    {
        public void Visit(Lion lion)
        {
            Console.WriteLine("Watching Lion");
        }

        public void Visit(Monkey monkey)
        {
            Console.WriteLine("Watching Monkey");
        }

        public void Visit(Bear bear)
        {
            Console.WriteLine("Watching Bear");
        }

        public void Visit(Giraffe giraffe)
        {
            Console.WriteLine("Watching Giraffe");
        }
    }
}
