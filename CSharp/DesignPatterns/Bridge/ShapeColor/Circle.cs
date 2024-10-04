namespace DesignPatterns.Bridge.ShapeColor
{
    internal class Circle : Shape
    {
        public Circle(Color color) : base(color)
        {
        }
        public override string ToString()
        {
            return $"Circle Details:\n" +
                   $"Color: {_color}";
        }
    }
}
