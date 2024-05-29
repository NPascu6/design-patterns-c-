using VisitorPatternZoo.cs.Visitor;

namespace VisitorPatternZoo.cs.Elements
{
    internal class Bear : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
