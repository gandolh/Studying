namespace DesignPatterns.CommandPattern
{
    internal abstract class Command
    {
        protected CommandMain app;
        protected Editor editor;
        protected string backup;

        protected Command(CommandMain app, Editor editor)
        {
            this.app = app;
            this.editor = editor;
            backup = string.Empty;
        }

        public void SetEditor(Editor editor)
        {
            this.editor = editor;
        }

        public void SaveBackup()
        {
            this.backup = editor.Text;
        }
        public void Undo()
        {
            editor.Text = backup;
        }
        //returns true if should be saved in history, false otherwise
        public abstract bool Execute();
        

    }
}
