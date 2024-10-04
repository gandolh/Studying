using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal interface IButton
    {
        void OnClick(Action closeDialog);
        void Render();
    }
}
