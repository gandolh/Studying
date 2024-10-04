namespace DesignPatterns.Flyweight
{
    internal class Tree
    {
        public int X;
        public int Y;
        public TreeType type;

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            this.type = type;
        }

        public void Draw()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Tree Details:\n" +
                   $"Position (X, Y): ({X}, {Y})\n" +
                   $"Tree _type: {type}";
        }
    }
}
