using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class TurkiyeShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }
}
