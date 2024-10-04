namespace DesignPatterns.Observer
{
    internal class Editor
    {
        private EventManager _eventManager;
        public Editor()
        {
            _eventManager = new EventManager();
            IEventListener loggingListener = new LoggingListener();
            IEventListener loggingListener2 = new LoggingListener();
            IEventListener alertListener = new EmailAlertsListener();
            _eventManager.Subscribe(loggingListener, EventType.Log);
            _eventManager.Subscribe(loggingListener2, EventType.Log);
            _eventManager.Subscribe(alertListener, EventType.Alert);
        }

        public void OpenFile(){
            _eventManager.Notify("Log type message, opened file", EventType.Log);
        }
        public void SaveFile()
        {
            _eventManager.Notify("Alert type message, couldn't save", EventType.Alert);
        }

    }
}
