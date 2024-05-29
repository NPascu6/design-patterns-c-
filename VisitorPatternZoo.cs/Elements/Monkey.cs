using VisitorPatternZoo.cs.Visitor;

namespace VisitorPatternZoo.cs.Elements
{
    internal class Monkey : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
