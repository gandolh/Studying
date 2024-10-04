namespace DesignPatterns.IteratorPattern
{
    internal interface IProfileIterator
    {
        public Profile GetNext();
        public bool HasMore();
    }
}
