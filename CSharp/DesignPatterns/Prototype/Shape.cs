namespace DesignPatterns.Prototype
{
    internal abstract class Shape
    {
        protected int X, Y;
        protected string Color = string.Empty;

        public Shape(){}
        public Shape(int x, int y, string color)
        {
            X = x;
            Y= y;
            Color = color;
        }

        public Shape(Shape source)
        {
            X= source.X;
            Y= source.Y;
            Color = source.Color;  
        }

        public abstract Shape Clone();


        public override string ToString()
        {
            return $"Shapes Details:\n" +
                   $"X: {X}\n" +
                   $"Y: {Y}\n" +
                   $"Color: {Color}";
        }
    }
}
