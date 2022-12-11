using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class AzerbaycanShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }
}
