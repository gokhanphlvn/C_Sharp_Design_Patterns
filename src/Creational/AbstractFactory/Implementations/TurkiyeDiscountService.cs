using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class TurkiyeDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }
}
