namespace DesignPatterns.AbstractFactory
{
    internal class MacFactory : GuiFactory
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }

        public override ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
