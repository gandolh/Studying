namespace DesignPatterns.Mediator
{
    internal class Button : Component
    {
        public Button(IMediator dialog) : base(dialog)
        {
        }
    }
}
