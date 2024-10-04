namespace DesignPatterns.Observer
{
    internal class LoggingListener : IEventListener
    {
        public void Update(object data)
        {
            Console.WriteLine("LoggingListener: {0}", data);
        }
    }
}
