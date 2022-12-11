using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;
        public ShoppingCart(IShippingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();

            _shippingCostsService = factory.CreateShippingCostsService();

            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts} - Type : {_discountService.GetType().Name.Replace("DiscountService", "")}");
        }
    }
}
