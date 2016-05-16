using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public class ApplicationShoppingBag : IShoppingBag<string>
    {
        public string Id { get; set; }
        public IEnumerable<ShoppingBagItem<string>> Items { get; set; }
        public string UserId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }
        public decimal? Discount { get; set; }
        public IEnumerable<DiscountItem> DiscountItems { get; set; }
        public string Notes { get; set; }

        public ApplicationShoppingBag()
        {
            Id = Guid.NewGuid().ToString();
            Items=new List<ShoppingBagItem<string>>();
            DiscountItems = new List<DiscountItem>();
        }
    }

    public class ShoppingBagItem<TKey>
    {
        public TKey Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public List<KeyValueItem> Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }

}