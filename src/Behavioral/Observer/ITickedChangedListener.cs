namespace Observer
{
    /// <summary>
    /// Observer
    /// </summary>
    public interface ITickedChangedListener
    {
        void ReceiveTickedChangeNotification(TickedChange tickedChanged);
    }
}
