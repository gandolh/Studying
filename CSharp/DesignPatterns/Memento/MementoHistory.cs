
namespace DesignPatterns.Memento
{
    internal class MementoHistory
    {
        private Stack<IMemento> _history;
        public MementoHistory()
        {
            _history = new Stack<IMemento>();
        }

        public void Push(IMemento memento)
        {
            _history.Push(memento);
        }

        public IMemento Pop()
        {
          return _history.Pop();
        }
    }
}
