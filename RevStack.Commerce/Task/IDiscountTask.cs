using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public interface IDiscountTask<TKey>
    {
        IShoppingBag<TKey> Run(IShoppingBag<TKey> bag, IEnumerable<IDiscount> discounts, string code);
        Tuple<bool, string> Validate(IShoppingBag<TKey> bag, IDiscount discount);
        RuleType RuleType { get; }
        DiscountType Type { get; }
    }

    
}