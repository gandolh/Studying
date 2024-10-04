using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows button");
        }
    }
}
