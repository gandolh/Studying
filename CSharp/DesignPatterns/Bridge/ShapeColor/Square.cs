using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.ShapeColor
{
    internal class Square : Shape
    {
        public Square(Color color) : base(color)
        {
        }

        public override string ToString()
        {
            return $"Square Details:\n" +
                   $"Color: {_color}";
        }
    }
}
