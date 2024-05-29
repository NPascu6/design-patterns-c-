using VisitorPatternZoo.cs.Visitor;

namespace VisitorPatternZoo.cs.Elements
{
    internal interface IAnimal
    {
        void Accept(IVisitor visitor);
    }
}
