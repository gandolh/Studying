namespace DesignPatterns.Strategy.RouteStrategy
{
    internal class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(int source, int dest)
        {
            Console.WriteLine("Public transport from {0} to {1}", source, dest);
        }
    }
}
