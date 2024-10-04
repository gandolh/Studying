namespace DesignPatterns.Mediator
{
    internal interface IMediator
    {
        public void Notify(Component sender, string @event);
    }
}
