using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    internal class TurkiyeShippingCartPurchaseFactory : IShippingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new TurkiyeDiscountService();

        public IShippingCostsService CreateShippingCostsService() => new TurkiyeShippingCostsService();
    }
}
