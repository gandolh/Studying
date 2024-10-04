using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Notifiers
{
    internal class BaseDecorator : Notifier
    {
        private Notifier _wrapee;

        public BaseDecorator(Notifier wrapee)
        {
            _wrapee = wrapee;
        }
        public override void Send(string message)
        {
            _wrapee.Send(message);
        }
    }
}
