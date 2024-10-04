namespace DesignPatterns.CommandPattern
{
    internal class CutCommand : Command
    {
        public CutCommand(CommandMain app, Editor editor) : base(app, editor)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            app.Clipboard = editor.GetSelection();
            editor.DeleteSelection();
            return true;
        }

    }
}
