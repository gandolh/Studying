namespace DesignPatterns.ChainOfResponsability
{
    internal class Panel : Container
    {
        private string _modalHelpText = string.Empty;
        private string _title = string.Empty;

        public Panel(string title)
        {
            _title = title;
        }

        public override void ShowHelp()
        {
            if(_modalHelpText != string.Empty)
                Console.WriteLine(_modalHelpText);
            else
            base.ShowHelp();
        }

        public void SetHelpText(string helpText) { _modalHelpText = helpText; }
    }
}
