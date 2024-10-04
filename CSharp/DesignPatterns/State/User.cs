namespace DesignPatterns.State
{
    internal class User
    {
        public bool IsAdmin { get; set; }
        public bool IsAuthor { get; set; }

        public User(bool isAdmin, bool isAuthor)
        {
            IsAdmin = isAdmin;
            IsAuthor = isAuthor;
        }
    }
}
