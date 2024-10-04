namespace DesignPatterns.Visitor
{
    internal interface IShape
    {
        public void Move(int x, int y);
        public void Draw();
        public T Accept<T>(IVisitor<T> v);

    }
}
