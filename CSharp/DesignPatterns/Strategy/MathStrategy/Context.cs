namespace DesignPatterns.Strategy.MathStrategy
{
    internal class Context
    {

        public IOperation Strategy { private get; set; }

        public int Execute(int a, int b)
        {
            return Strategy.Execute(a, b);
        }
    }
}
