using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class SquarePeg
    {
        public int _width;

        public SquarePeg(int width)
        {
            _width = width;
        }

        public int GetWidth() { return _width; }

    }
}
