using System.Collections.Generic;

namespace DesignPatterns.IteratorPattern
{
    internal class Facebook : ISocialNetwork
    {
        public IProfileIterator CreateCoworkersIterator(int profileId)
        {
            return new FacebookIterator(this, profileId, 0);
        }

        public IProfileIterator CreateFriendsIterator(int profileId)
        {
            return new FacebookIterator(this, profileId, 1);
        }

        internal Profile[] SocialGraphRequest(int profileId, int type)
        {
            // simulate fetching from graphql and getting a list
            if (type == 0)
                return [
                    new Profile(1, "john@example.com"),
                    new Profile(2, "jane@example.com"),
                    new Profile(3, "user@example.com")
                ];
            else return [
                new Profile(4, "alex@example.com"),
                new Profile(5, "emma@example.com"),
                new Profile(6, "test@example.com")
            ];

        }
    }
}
