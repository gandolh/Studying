namespace DesignPatterns.IteratorPattern
{
    internal interface ISocialNetwork
    {
        public IProfileIterator CreateFriendsIterator(int profileId);
        public IProfileIterator CreateCoworkersIterator(int profileId);
    }
}
