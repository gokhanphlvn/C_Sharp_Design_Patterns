namespace Bridge
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }

    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class OneUSDCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }

    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class TwoUSDCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}
