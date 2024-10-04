namespace DesignPatterns.Memento
{
    internal abstract class Command
    {
        protected Editor _editor;
        protected MementoHistory _history;

        public Command(Editor editor)
        {
            _editor = editor;
            _history = new MementoHistory();
        }

        protected void MakeBackup()
        {
            _history.Push(_editor.CreateSnapshot());
        }

        public void Undo()
        {
            IMemento memento = _history.Pop();
            memento.Restore();
        }

        public virtual void Execute()
        {
            MakeBackup();
        }
    }
}
