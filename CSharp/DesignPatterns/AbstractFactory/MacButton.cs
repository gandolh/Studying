namespace DesignPatterns.AbstractFactory
{
    internal class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Mac button");
        }
    }
}
