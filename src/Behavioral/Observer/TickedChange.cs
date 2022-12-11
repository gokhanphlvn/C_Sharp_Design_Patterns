namespace Observer
{
    public class TickedChange
    {
        public int Amount { get; private set; }
        public int ArtistId { get; private set; }
        public TickedChange(int amount, int artistId)
        {
            Amount = amount;
            ArtistId = artistId;
        }
    }
}
