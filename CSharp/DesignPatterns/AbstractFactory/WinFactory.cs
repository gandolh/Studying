using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class WinFactory : GuiFactory
    {
        public override IButton CreateButton()
        {
            return new WinButton();
        }

        public override ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
