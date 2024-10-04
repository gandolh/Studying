namespace DesignPatterns.Strategy.RouteStrategy
{
    internal class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(int source, int dest)
        {
            Console.WriteLine("Walking from {0} to {1}", source, dest);
        }
    }
}
