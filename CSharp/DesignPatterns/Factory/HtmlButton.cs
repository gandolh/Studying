using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class HtmlButton : IButton
    {
        public void OnClick(Action closeDialog)
        {
        }

        public void Render()
        {
            Console.WriteLine("This is HTML Button");
        }
    }
}
