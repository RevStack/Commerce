using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RevStack.Mvc;

namespace RevStack.Commerce
{
    public static class Extensions
    {
        public static string ToShoppingBag<TOrder,TPayment,TBag,TKey>(this IEnumerable<OrderItem<TKey>> items,TBag bag, TOrder order)
             where TBag : class, IShoppingBag<TKey>
             where TPayment : class, IPayment
             where TOrder : class, IOrder<TPayment, TKey>
        {
            bag.Items= order.Items.Select(x => Mapper.Map<ShoppingBagItem<TKey>>(x));
            bag.Discount = order.Discount;
            bag.Shipping = order.Shipping;
            bag.Subtotal = order.Subtotal;
            bag.Tax = order.Tax;
            bag.Total = order.Total;

            return Json.SerializeObject<TBag>(bag, true, true);
        }

        public static IEnumerable<DiscountItem> ReplaceDiscountItem(this IEnumerable<DiscountItem> src, DiscountItem item)
        {
            foreach (var e in src)
            {
                if (e.Code == item.Code)
                {
                    e.Total = item.Total;
                    e.Sku = item.Sku;
                    e.RuleType = item.RuleType;
                }
            }

            return src;
        }

        public static IEnumerable<DiscountItem> RemoveDiscountItem(this IEnumerable<DiscountItem> src, DiscountItem item)
        {
            var e = src.Where(x => x.Code == item.Code);
            if (e.Any())
            {
                var x = e.FirstOrDefault();
                var items = src.ToList();
                items.Remove(x);
                return items;
            }
            else
            {
                return src;
            }
        }

    }
}