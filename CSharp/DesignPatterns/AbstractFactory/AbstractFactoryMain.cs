namespace DesignPatterns.AbstractFactory
{
    internal class AbstractFactoryMain
    {
        private GuiFactory factory;
        private IButton button;
        private ICheckbox checkbox;
        public AbstractFactoryMain(OsType osType)
        {
            if (osType == OsType.Windows)
                factory = new WinFactory();
            else if (osType == OsType.Mac)
                factory = new MacFactory();
            else
                throw new Exception("Unknown operating system");

            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void Main()
        {
            button.Render();
            checkbox.Render();
        }

    }
}
