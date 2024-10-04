namespace DesignPatterns.Factory
{
    internal class FactoryMain
    {
        private Dialog dialog;
        public FactoryMain(OsType osType)
        {
            if (osType == OsType.Windows)
                dialog = new WindowsDialog();
            else if (osType == OsType.Web)
                dialog = new WebDialog();
            else
                throw new Exception("Unknown operating system");
        }
    
        public void main()
        {
            dialog.Render();
        }
    }
}
