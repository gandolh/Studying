namespace DesignPatterns.Prototype
{
    internal class Button : IPrototype
    {
        private int x, y;
        private string color;


        public Button(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public Button(Button prototype)
        {
            this.x=  prototype.x;
            this.y=  prototype.y;
            this.color=  prototype.color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public IPrototype Clone()
        {
            return new Button(this);
        }

        public override string ToString()
        {
            return $"Button Details:\n" +
                   $"X: {x}\n" +
                   $"Y: {y}\n" +
                   $"Color: {color}";
        }

    }
}
