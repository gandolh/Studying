namespace DesignPatterns.State
{
    internal class StateMain
    {
        public void Main()
        {
            Document document = new Document();
            User admin = new User(isAdmin: true, isAuthor: false);
            User author = new User(isAdmin: false, isAuthor: true);
            User normalUser = new User(isAdmin: false, isAuthor: false);

            Draft draft = new Draft(document, admin);
            document.Render();
            document.Publish();
            document.Render();

            Console.WriteLine("=========");
            draft = new Draft(document, author);
            document.Render();
            document.Publish();
            document.Render();
            document.SetUser(admin);
            document.Publish();
            document.Render();

        }
    }
}
