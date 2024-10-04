namespace DesignPatterns.Composite
{
    internal class ImageEditor
    {
        private IGraphic canvas;

        public ImageEditor()
        {
            CompoundGraphic canvas = new CompoundGraphic();
            Circle circle = new Circle(10, 20, 5);
            Dot dot = new Dot(30, 40);
            CompoundGraphic newCompound = new CompoundGraphic();
            Dot dot1 = new Dot(50, 60);
            Dot dot2 = new Dot(70, 80);
            newCompound.AddChild(dot1);
            newCompound.AddChild(dot2);
            canvas.AddChild(circle);
            canvas.AddChild(newCompound);
            canvas.AddChild(dot);
            this.canvas = canvas;
        }

        public void Draw()
        {
            canvas.Draw();
        }
    }
}
