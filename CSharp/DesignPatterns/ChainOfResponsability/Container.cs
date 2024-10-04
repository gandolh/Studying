namespace DesignPatterns.ChainOfResponsability
{
    internal class Container : Component
    {
        public List<Component> Children = new List<Component>();


        public void Add(Component child)
        {
            child.SetContainer(this);
            Children.Add(child);
        }
    }
}
