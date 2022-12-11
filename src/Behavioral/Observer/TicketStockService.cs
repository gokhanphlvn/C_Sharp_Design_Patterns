namespace Observer
{
    /// <summary>
    /// ConcreteObserver
    /// </summary>
    public class TicketStockService : ITickedChangedListener
    {
        public void ReceiveTickedChangeNotification(TickedChange tickedChanged)
        {
            //Update Local datastore
            Console.WriteLine($"{nameof(TicketStockService)} notified of tickerd change: artist {tickedChanged.ArtistId}, amount {tickedChanged.Amount}");
        }
    }
}
