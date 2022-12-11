namespace FactoryMethod.Implementations
{
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}
