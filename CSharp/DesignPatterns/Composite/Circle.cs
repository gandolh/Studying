namespace DesignPatterns.Composite
{
    internal class Circle : Dot
    {
        public int radius;
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Circle Details: " +
                   $"Center (X, Y): ({x}, {y}); " +
                   $"Radius: {radius}";
        }
    }
}
