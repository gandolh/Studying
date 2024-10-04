using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Notifiers
{
    internal class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(Notifier wrapee) : base(wrapee)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("From SMS: {0}", message);
        }
    }
}
