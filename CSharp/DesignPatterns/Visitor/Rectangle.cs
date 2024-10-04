namespace DesignPatterns.Visitor
{
    internal class Rectangle : IShape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public T Accept<T>(IVisitor<T> v)
        {
           return v.VisitRectangle(this);
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
            return $"Rectangle Details:\n" +
                   $"Position (X, Y): ({X}, {Y})\n" +
                   $"Dimensions (Width x Height): {Width} x {Height}";
        }

    }
}
