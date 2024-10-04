namespace DesignPatterns.Strategy.MathStrategy
{
    internal class MultiplyStrategy : IOperation
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
