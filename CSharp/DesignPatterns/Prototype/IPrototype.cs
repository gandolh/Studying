namespace DesignPatterns.Prototype
{
    internal interface IPrototype
    {
        public string GetColor();
        public IPrototype Clone();
    }
}
