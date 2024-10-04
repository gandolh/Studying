namespace DesignPatterns.CommandPattern
{
    internal class CommandMain
    {
        public string Clipboard;
        private Editor[] _editors;
        private Editor _activeEditor;
        private CommandHistory _history;
        private Command _copyCommand;
        private Command _cutCommand;
        private Command _pasteCommand;
        private Command _undoCommand;

        public CommandMain()
        {
            _history = new CommandHistory();
            _editors = new Editor[1];
            _editors[0] = new Editor();
            _activeEditor = _editors[0];
            Clipboard = string.Empty;
            _copyCommand = new CopyCommand(this, _activeEditor);
            _cutCommand = new CutCommand(this, _activeEditor);
            _pasteCommand = new PasteCommand(this, _activeEditor);
            _undoCommand = new UndoCommand(this, _activeEditor);
        }

        public void Main()
        {
            
            Console.WriteLine("Initial string: {0}", _activeEditor.Text);
            ExecuteCommand(_copyCommand);
            ExecuteCommand(_pasteCommand);
            Console.WriteLine("after copy and paste: {0}", _activeEditor.Text);
            ExecuteCommand(_cutCommand);
            Console.WriteLine("after cut: {0}", _activeEditor.Text);
            ExecuteCommand(_pasteCommand);
            ExecuteCommand(_pasteCommand);
            Console.WriteLine("after 2 paste: {0}", _activeEditor.Text);
            ExecuteCommand(_undoCommand);
            Console.WriteLine("after undo: {0}", _activeEditor.Text);
            ExecuteCommand(_undoCommand);
            Console.WriteLine("after undoing the undo: {0}", _activeEditor.Text);


        }

        public void CreateUi()
        {
            // create buttons, menu, stuffs.
            // Add commands to event listeners for ui elemenents
        }



        // do this on button press or smth from UI
        public void ExecuteCommand(Command command)
        {
            command.SetEditor(_activeEditor);
            if (command.Execute())
                _history.Push(command);
        }

        public void Undo() { 
            Command command = _history.Pop();
            if (command != null)
                command.Undo();
        }
    }
}
