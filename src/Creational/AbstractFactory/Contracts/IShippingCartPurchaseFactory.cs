namespace AbstractFactory.Contracts
{
    public interface IShippingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostsService CreateShippingCostsService();
    }
}
