using DesignPatterns.Strategy.MathStrategy;
using DesignPatterns.Strategy.RouteStrategy;

namespace DesignPatterns.Strategy
{
    internal class StrategyMain
    {

        public void Main()
        {
            // Route Strategy
            int source = 10;
            int dest = 20;
            IRouteStrategy pts = new PublicTransportStrategy();
            IRouteStrategy ws = new WalkingStrategy();
            IRouteStrategy rs = new RoadStrategy();
            Navigator navigator = new Navigator(pts);
            navigator.BuildRoute(source, dest);
            navigator.RouteStrategy = ws;
            navigator.BuildRoute(source, dest);
            navigator.RouteStrategy = rs;
            navigator.BuildRoute(source, dest);

            // Math strategy
            Console.WriteLine("=== Math example ===");
            IOperation add = new AddStrategy();
            IOperation sub = new SubstractStrategy();
            IOperation multiply = new MultiplyStrategy();
            Context context = new Context();
            int a = 2;
            int b = 5;
            context.Strategy = add;
            Console.WriteLine("add: {0}", context.Execute(a, b));
            context.Strategy = sub;
            Console.WriteLine("sub: {0}", context.Execute(a, b));
            context.Strategy = multiply;
            Console.WriteLine("multiply: {0}", context.Execute(a, b));

        }
    }
}
