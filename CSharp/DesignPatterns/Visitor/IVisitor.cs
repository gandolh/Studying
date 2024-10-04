
namespace DesignPatterns.Visitor
{
    internal interface IVisitor<T>
    {
        public T VisitDot(Dot d);
        public T VisitCircle(Circle c);
        public T VisitRectangle(Rectangle r);
        public T VisitCompoundGraphic(CompoundShape cg);
    }
}
