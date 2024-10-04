namespace DesignPatterns.Memento
{
    internal class Editor
    {
        public string Text {  get; set; }
        public int CursorX { private get; set; }
        public int CursorY { private get; set; }
        public int SelectionWidth { private get; set; }

        public Editor()
        {
            Text = "This is a sample text";
            CursorX = 2;
            CursorY = 1;
            SelectionWidth = 3;
        }

        public IMemento CreateSnapshot()
        {
            return new Snapshot(this, Text, CursorX, CursorY, SelectionWidth);
        }

        private class Snapshot : IMemento
        {
            private readonly Editor _editor;
            private readonly string _text;
            private readonly int _cursorX;
            private readonly int _cursorY;
            private readonly int _selectionWidth;

            public Snapshot(Editor editor, string text, int cursorX, int cursorY, int selectionWidth)
            {
                _editor = editor;
                _text = text;
                _cursorX = cursorX;
                _cursorY = cursorY;
                _selectionWidth = selectionWidth;
            }

            public void Restore()
            {
                _editor.Text = _text;
                _editor.SelectionWidth = _selectionWidth;  
                _editor.CursorX = _cursorX;
                _editor.CursorY = _cursorY;
            }
        }



    }
}
