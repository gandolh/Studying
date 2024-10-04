using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.ShapeColor
{
    internal class Color
    {
        protected int r, g, b;

        public Color(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public override string ToString()
        {
            return $"Color (R, G, B): ({r}, {g}, {b})";
        }
    }
}
