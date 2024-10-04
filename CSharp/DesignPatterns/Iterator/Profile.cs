namespace DesignPatterns.IteratorPattern
{
    internal class Profile
    {
        public int Id { get; init; }
        public string Email { get; init; } = string.Empty;

        public Profile(int id, string email)
        {
            Id = id;
            Email = email;
        }
    }
}
