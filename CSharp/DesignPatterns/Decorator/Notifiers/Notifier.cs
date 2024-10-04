namespace DesignPatterns.Decorator.Notifiers
{
    internal class Notifier
    {
        public virtual void Send(string message)
        {
            Console.WriteLine("From Email: {0}", message);
        }
    }
}
