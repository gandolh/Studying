namespace DesignPatterns.CommandPattern
{
    internal class UndoCommand : Command
    {
        public UndoCommand(CommandMain app, Editor editor) : base(app, editor)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            app.Undo();
            return true;
        }

    }
}
