namespace DesignPatterns.Visitor
{
    internal class Dot : IShape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public T Accept<T>(IVisitor<T> v)
        {
            return v.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine(this);
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Dot Details:\n" +
                   $"Position (X, Y): ({X}, {Y})";
        }
    }
}
