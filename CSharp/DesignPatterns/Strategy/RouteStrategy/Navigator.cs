namespace DesignPatterns.Strategy.RouteStrategy
{
    internal class Navigator
    {
        public IRouteStrategy RouteStrategy { private get; set; }

        public Navigator(IRouteStrategy routeStrategy)
        {
            RouteStrategy = routeStrategy;
        }

        public void BuildRoute(int source, int dest)
        {
            RouteStrategy.BuildRoute(source, dest);
        }
    }
}
