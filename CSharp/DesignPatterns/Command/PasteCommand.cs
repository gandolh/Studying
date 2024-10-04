namespace DesignPatterns.CommandPattern
{
    internal class PasteCommand : Command
    {
        public PasteCommand(CommandMain app, Editor editor) : base(app, editor)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            int cursorPosition = 5;
            editor.ReplaceSelection(cursorPosition, app.Clipboard);
            return true;
        }

     
    }
}
