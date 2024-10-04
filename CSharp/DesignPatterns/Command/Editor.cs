namespace DesignPatterns.CommandPattern
{
    internal class Editor
    {
        public string Text = "This is an example start text";

        public string GetSelection(int start = 2, int end = 5)
        {
            return Text.Substring(start, end - start);
        }
        public void DeleteSelection(int start = 2, int end = 5)
        {
            Text = Text.Remove(start, end - start);
        }

        public void ReplaceSelection(int position, string newText)
        {
            Text = Text.Insert(position, newText);
        }
    }
}
