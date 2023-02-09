using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
        public override void MakeSpecialDish()
        {
            // to overwrite it is neccesary that primary method to be
            //virtual.
            Console.WriteLine("The chef makes pizza scarioza");
        }
    }
}
