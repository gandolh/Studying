using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    internal class Checkbox : Component
    {
        private bool _checked = false;

        public Checkbox(IMediator dialog) : base(dialog)
        {
        }

        public override void Click()
        {
            _checked = !_checked;
            base.Click();
        }

        internal bool IsChecked()
        {
            return _checked;
        }
    }
}
