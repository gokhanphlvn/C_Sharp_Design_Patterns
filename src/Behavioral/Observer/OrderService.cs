namespace Observer
{
    /// <summary>
    /// ConcreteSubject
    /// </summary>
    public class OrderService : TickedChangedNotifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            //change local datastore.
            Console.WriteLine($"{nameof(OrderService)} is changing its state.");
            //notify observers
            Console.WriteLine($"{nameof(OrderService)} is notifying observers...");
            Notify(new TickedChange(artistId, amount));
        }
    }
}
