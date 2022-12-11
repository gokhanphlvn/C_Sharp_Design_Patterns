﻿namespace FactoryMethod.Implementations
{
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }
}
