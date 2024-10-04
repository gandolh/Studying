namespace DesignPatterns.CommandPattern
{
    internal class CommandHistory
    {
        private Stack<Command> History { get; set; } = new Stack<Command>();

        public void Push(Command command)
        {
            History.Push(command);
        }

        public Command Pop()
        {
            return History.Pop();
        }
    }
}
