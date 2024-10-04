using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.ShapeColor
{
    internal class Shape
    {
        protected Color _color;

        public Shape(Color color)
        {
            _color = color;
        }
    }
}
