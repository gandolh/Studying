namespace DesignPatterns.Mediator
{
    internal abstract class Component
    {
        IMediator _dialog;
        public Component(IMediator dialog)
        {
            _dialog = dialog;
        }

        public virtual void Click()
        {
            _dialog.Notify(this, "click");
        }
        public virtual void KeyPress(){
            _dialog.Notify(this, "keyPressed");    
        }
    }
}
