namespace Observer
{
    /// <summary>
    /// Subject
    /// </summary>
    public class TickedChangedNotifier
    {
        private List<ITickedChangedListener> _observers = new();
        public void AddObserver(ITickedChangedListener observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ITickedChangedListener observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(TickedChange tickedChange)
        {
            foreach (var observer in _observers)
            {
                observer.ReceiveTickedChangeNotification(tickedChange);
            }
        }
    }
}
