namespace DesignPatterns.Decorator.Notifiers
{
    internal class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier wrapee) : base(wrapee)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("From Slack: {0}", message);
        }
    }
}
