namespace DesignPatterns.Observer
{
    internal class EventManager
    {
        private Dictionary<EventType, List<IEventListener>> listeners = new();

        public void Subscribe(IEventListener listener, EventType eventType)
        {
            if (listeners.ContainsKey(eventType))
                listeners[eventType].Add(listener);
            else
                listeners.Add(eventType, new List<IEventListener>() { listener });
        }

        public void Unsubscribe(IEventListener listener, EventType eventType)
        {
            if (listeners.ContainsKey(eventType))
                listeners[eventType].Remove(listener);
        }

        public void Notify(Object data, EventType eventType)
        {
            var values = listeners[eventType];
            foreach (IEventListener listener in values)
                listener.Update(data);
        }

    }
}
