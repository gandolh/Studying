namespace DesignPatterns.IteratorPattern
{
    internal class SocialSpammer
    {

        public void Send(IProfileIterator iterator, string message)
        {
            while (iterator.HasMore())
            {
                Profile profile = iterator.GetNext();
                Console.WriteLine("sent message \"{0}\" for user with email: \"{1}\"", message, profile.Email);
            }
        }
    }
}
