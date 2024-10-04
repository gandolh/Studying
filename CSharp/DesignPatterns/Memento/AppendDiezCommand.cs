namespace DesignPatterns.Memento
{
    internal class AppendDiezCommand : Command
    {
        public AppendDiezCommand(Editor editor) : base(editor)
        {
        }

        public override void Execute()
        {
            base.Execute();
            _editor.Text =  _editor.Text + "#";
        }
    }
}
