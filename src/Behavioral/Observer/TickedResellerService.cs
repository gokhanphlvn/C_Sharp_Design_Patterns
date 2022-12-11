namespace Observer
{
    /// <summary>
    /// ConcreteObserver
    /// </summary>
    public class TickedResellerService : ITickedChangedListener
    {
        public void ReceiveTickedChangeNotification(TickedChange tickedChanged)
        {
            //Update Local datastore
            Console.WriteLine($"{nameof(TickedResellerService)} notified of tickerd change: artist {tickedChanged.ArtistId}, amount {tickedChanged.Amount}");
        }
    }
}
