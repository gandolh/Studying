using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(Rectangle source) : base(source)
        {
            _width = source._width;
            _height = source._height;
        }

        public Rectangle(int width, int height, int x, int y, string color) : base(x,y,color)
        {
            _width = width;
            _height = height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            return $"Rectangle Details:\n" +
                   $"X: {X}\n" +
                   $"Y: {Y}\n" +
                   $"Color: {Color}\n" +
                   $"Width: {_width}\n" +
                   $"Height: {_height}";
        }
    }
}
