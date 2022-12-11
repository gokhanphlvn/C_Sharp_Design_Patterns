namespace Facade
{
    /// <summary>
    /// Subsystem class
    /// </summary>
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId)
        {

            return (customerId > 5);
        }
    }
}
