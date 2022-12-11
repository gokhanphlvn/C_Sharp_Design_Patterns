namespace Facade
{
    /// <summary>
    /// Facade
    /// </summary>
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfWeekFactorService _dayOfWeekFactorService= new();

        public double CalculateDiscountPercantege(int customerId)
        {
            if (!_orderService.HasEnoughOrders(customerId))
            {
                return 0;
            }

            return _customerDiscountBaseService.CalculateDiscountBase(customerId) * _dayOfWeekFactorService.CalculateDayOfTheWeekFactor();
        }
    }
}
