namespace DesignPatterns.Prototype
{
    internal class Circle : Shape
    {
        private int _radius;
        public Circle(int radius, int x, int y, string color) : base(x,y,color)
        {
            _radius = radius;
        }

        public Circle(Circle source) : base(source)
        {
            _radius = source._radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
        public override string ToString()
        {
            return $"Circle Details:\n" +
                   $"X: {X}\n" +
                   $"Y: {Y}\n" +
                   $"Color: {Color}\n" +
                   $"Radius: {_radius}";
        }

    }
}
