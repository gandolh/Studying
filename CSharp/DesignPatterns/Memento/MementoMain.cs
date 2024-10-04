namespace DesignPatterns.Memento
{
    internal class MementoMain
    {

        public void Main()
        {
            Editor editor = new Editor();
            var appendCommand = new AppendDiezCommand(editor);
            Console.WriteLine("editor text before append command: {0}", editor.Text);
            appendCommand.Execute();
            appendCommand.Execute();
            appendCommand.Execute();
            Console.WriteLine("editor text after append command: {0}", editor.Text);
            appendCommand.Undo();
            appendCommand.Undo();
            Console.WriteLine("editor text after 2 undos: {0}", editor.Text);
        }
    }
}
