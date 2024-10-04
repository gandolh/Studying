namespace DesignPatterns.State
{
    internal class Draft : IState
    {

        private Document _document;
        private User _user;

        public Draft(Document document, User user)
        {
            _document = document;
            _user = user;
            _document.ChangeState(this);
        }

        public void Publish()
        {
            if (_user.IsAdmin) 
                _document.ChangeState(new Published(_document,_user));
            else
                _document.ChangeState(new Moderation(_document, _user));
        }

        public void Render()
        {
            if (_user.IsAdmin || _user.IsAuthor)
            {
                // render document
                Console.WriteLine("Render draft");
            }
            else
                throw new Exception("You don't have access to this _document");
        }

        public void SetUser(User user)
        {
            _user = user;
        }
    }
}
