namespace DesignPatterns.Composite
{
    internal class CompoundGraphic : IGraphic
    {
        private List<IGraphic> _children;

        public CompoundGraphic()
        {
            _children = new List<IGraphic>();
        }

        public void AddChild(IGraphic child)
        {
            _children.Add(child);
        }

        public void Remove(IGraphic child)
        {
            _children.Remove(child);
        }

        public void Move(int x, int y)
        {
            foreach (var child in _children)
                child.Move(x, y);
        }

        public void Draw()
        {
            Console.WriteLine("## START Compound");
            foreach (var child in _children)
            {
                Console.WriteLine($"# Child number: {_children.IndexOf(child)}");
                child.Draw();
            }
            Console.WriteLine("## END Compound");

        }
    }
}
