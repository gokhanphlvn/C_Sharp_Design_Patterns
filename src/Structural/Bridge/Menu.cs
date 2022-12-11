namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null!;
        public abstract int CalculatePrice();
        public Menu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }
}
