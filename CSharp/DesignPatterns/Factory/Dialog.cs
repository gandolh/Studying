namespace DesignPatterns.Factory
{
    internal abstract class Dialog
    {
        public abstract IButton CreateButton();
        public void Render()
        {
            IButton okButton = CreateButton();
            okButton.OnClick(CloseDialog);
            okButton.Render();
        }

        public void CloseDialog(){}
    }
}
