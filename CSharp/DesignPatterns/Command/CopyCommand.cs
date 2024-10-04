namespace DesignPatterns.CommandPattern
{
    internal class CopyCommand : Command
    {
        public CopyCommand(CommandMain app, Editor editor) : base(app, editor)
        {
        }

        public override bool Execute()
        {
            app.Clipboard = editor.GetSelection();
            return false;
        }

    }
}
