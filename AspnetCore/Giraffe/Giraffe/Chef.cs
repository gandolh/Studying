using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            //for permission of override in italianChef
            Console.WriteLine("The chef makes bbq plate");
        }
    }
}
