

namespace DesignPatterns.State
{
    internal class Document : IState
    {
        private IState _state;

        public void Publish()
        {
            _state.Publish();
        }

        public void Render()
        {
            _state.Render();
        }

        internal void ChangeState(IState newState)
        {
            _state = newState;
        }

        public void SetUser(User admin)
        {
            _state.SetUser(admin);
        }
    }
}
