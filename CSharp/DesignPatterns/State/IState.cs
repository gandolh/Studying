namespace DesignPatterns.State
{
    internal interface IState
    {
        public void Render();
        public void Publish();
        public void SetUser(User user);
    }
}
