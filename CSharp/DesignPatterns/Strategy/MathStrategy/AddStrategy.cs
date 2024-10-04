namespace DesignPatterns.Strategy.MathStrategy
{
    internal class AddStrategy : IOperation
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
