namespace DesignPatterns.AbstractFactory
{
    internal abstract class GuiFactory
    {
        public abstract IButton CreateButton();
        public abstract ICheckbox CreateCheckbox();
    }
}
