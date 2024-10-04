namespace DesignPatterns.Composite
{
    internal class Dot : IGraphic
    {
        public int x, y;
        public Dot(int x, int y) { }
        public void Move(int x, int y) { }
        public virtual void Draw() { Console.WriteLine(this); }

        public override string ToString()
        {
            return $"Dot Details: " +
                   $"Position (X, Y): ({x}, {y})";
        }
    }
}
