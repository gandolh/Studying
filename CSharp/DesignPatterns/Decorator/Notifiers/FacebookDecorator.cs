namespace DesignPatterns.Decorator.Notifiers
{
    internal class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(Notifier wrapee) : base(wrapee)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("From Facebook: {0}", message);
        }
    }
}
