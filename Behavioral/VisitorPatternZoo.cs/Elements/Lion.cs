using VisitorPatternZoo.cs.Visitor;

namespace VisitorPatternZoo.cs.Elements
{
    internal class Lion : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
