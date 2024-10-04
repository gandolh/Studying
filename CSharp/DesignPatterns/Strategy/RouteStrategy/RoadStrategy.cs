namespace DesignPatterns.Strategy.RouteStrategy
{
    internal class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute(int source, int dest)
        {
            Console.WriteLine("Road from {0} to {1}", source, dest);
        }
    }
}
