using System.Diagnostics;

namespace DesignPatterns.IteratorPattern
{
    internal class IteratorMain
    {
        private SocialSpammer Spammer;
        private ISocialNetwork Network;

        public IteratorMain()
        {
            Spammer = new SocialSpammer();
            Network = new Facebook();
        }

        public void Main()
        {
            var myProfile = new Profile(1, "john@example.com");
            SendSpamToCoworkers(myProfile);
            SendSpamToFriends(myProfile);
        }
        
        public void SendSpamToFriends(Profile profile)
        {
            IProfileIterator iterator = Network.CreateFriendsIterator(profile.Id);
            Spammer.Send(iterator, "hello friend!");
        }

        public void SendSpamToCoworkers(Profile profile)
        {
            IProfileIterator iterator = Network.CreateCoworkersIterator(profile.Id);
            Spammer.Send(iterator, "hello coworker!");
        }


    }
}
