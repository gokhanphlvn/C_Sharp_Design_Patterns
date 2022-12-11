using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class AzerbaycanShippingCartPurchaseFactory : IShippingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new AzerbaycanDiscountService();

        public IShippingCostsService CreateShippingCostsService() => new AzerbaycanShippingCostsService();
    }
}
