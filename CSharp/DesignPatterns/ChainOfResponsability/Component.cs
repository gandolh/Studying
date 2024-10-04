
namespace DesignPatterns.ChainOfResponsability
{
    internal class Component : IComponentWithContextualHelp
    {
        protected Container? Container { get; set; }
        public string? _tooltipText;

        public Component()
        {
            
        }

        public virtual void ShowHelp()
        {
            if(_tooltipText != null)
                Console.WriteLine(_tooltipText);
            else
                Container?.ShowHelp();
        }

        public void SetTooltipText(string? tooltipText)
        {
            _tooltipText = tooltipText;
        }

        internal void SetContainer(Container container)
        {
            Container = container;
        }
    }
}
