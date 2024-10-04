namespace DesignPatterns.Strategy.RouteStrategy
{
    internal interface IRouteStrategy
    {
        public void BuildRoute(int source, int dest);
    }
}
