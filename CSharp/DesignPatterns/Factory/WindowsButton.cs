using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class WindowsButton : IButton
    {
        public void OnClick(Action closeDialog){}

        public void Render()
        {
            Console.WriteLine("This is Windows Button");

        }
    }
}
