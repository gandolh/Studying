namespace DesignPatterns.Observer
{
    internal class EmailAlertsListener : IEventListener
    {
        public void Update(object data)
        {
            Console.WriteLine("EmailAlertsListener: {0}", data);

        }
    }
}
