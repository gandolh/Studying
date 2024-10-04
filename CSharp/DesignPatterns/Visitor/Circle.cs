namespace DesignPatterns.Visitor
{
    internal class Circle : IShape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; private set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public T Accept<T>(IVisitor<T> v)
        {
           return v.VisitCircle(this);
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
            return $"Circle Details:\n" +
                   $"Center (X, Y): ({X}, {Y})\n" +
                   $"Radius: {Radius}";
        }
    }
}
