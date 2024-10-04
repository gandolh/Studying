using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class WinCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Windows checkbox");
        }
    }
}
