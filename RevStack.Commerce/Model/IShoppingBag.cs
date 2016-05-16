using System;
using System.Collections.Generic;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public interface IShoppingBag<TKey> : IEntity<TKey>
    {
        IEnumerable<ShoppingBagItem<TKey>> Items { get; set; }
        TKey UserId { get; set; }
        decimal Subtotal { get; set; }
        decimal Tax { get; set; }
        decimal Shipping { get; set; }
        decimal Total { get; set; }
        decimal? Discount { get; set; }
        IEnumerable<DiscountItem> DiscountItems { get; set; }
        string Notes { get; set; }
    }
}