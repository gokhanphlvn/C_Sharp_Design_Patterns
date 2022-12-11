using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class AzerbaycanDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }
}
