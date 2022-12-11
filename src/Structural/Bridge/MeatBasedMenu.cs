namespace Bridge
{
    /// <summary>
    /// Refined Abstrction
    /// </summary>
    public class MeatBasedMenu : Menu
    {
        public MeatBasedMenu(ICoupon coupon) : base(coupon) { }

        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }
}
