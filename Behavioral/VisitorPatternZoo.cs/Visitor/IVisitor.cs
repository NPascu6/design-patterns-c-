using VisitorPatternZoo.cs.Elements;

namespace VisitorPatternZoo.cs.Visitor
{
    internal interface IVisitor
    {
        void Visit(Lion lion);
        void Visit(Monkey monkey);
        void Visit(Giraffe giraffe);
        void Visit(Bear bear);
    }
}
