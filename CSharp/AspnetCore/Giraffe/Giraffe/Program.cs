using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            //chef.makePasta(); //error. Not inverse inheritance;
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
            Console.ReadLine();
        }
    }
}
