namespace Bridge
{
    /// <summary>
    /// Refined Abstrction
    /// </summary>
    public class VegetarianMenu : Menu
    {
        public VegetarianMenu(ICoupon coupon) : base(coupon) { }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }
}
