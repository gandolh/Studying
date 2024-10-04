using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Mac checkbox");
        }
    }
}
