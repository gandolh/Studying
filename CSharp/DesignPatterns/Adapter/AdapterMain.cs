using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class AdapterMain
    {
        public AdapterMain(){}

        public void Main()
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);
            Console.WriteLine(hole.Fits(rpeg));

            var smallSqpeg = new SquarePeg(5);
            var largeSqpeg = new SquarePeg(10);
            //hole.fits(small_sqpeg);

            RoundPeg smallSqpegAdapter = new SquarePegAdapter(smallSqpeg);
            RoundPeg largeSqpegAdapter = new SquarePegAdapter(largeSqpeg);
            Console.WriteLine(hole.Fits(smallSqpegAdapter));
            Console.WriteLine(hole.Fits(largeSqpegAdapter));
        }
    }
}
