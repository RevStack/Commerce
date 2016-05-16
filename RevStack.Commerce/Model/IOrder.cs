using System;
using System.Collections.Generic;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public interface IOrder<TPayment, TKey> : IEntity<TKey>
        where TPayment : class, IPayment
    {
        DateTime OrderDate { get; set; }
        OrderStatus OrderStatus { get; set; }
        TKey UserId { get; set; }
        bool IsAuthenticatedUser { get; set; }
        string Email { get; set; }
        IEnumerable<OrderItem<TKey>> Items { get; set; }
        BillingAddress BillingAddress { get; set; }
        ShippingAddress ShippingAddress { get; set; }
        decimal Subtotal { get; set; }
        decimal? Discount { get; set; }
        decimal Tax { get; set; }
        decimal Shipping { get; set; }
        decimal Total { get; set; }
        ShippingMethod ShippingMethod { get; set; }
        string Notes { get; set; }
        string TrackingUrl { get; set; }
        TPayment Payment { get; set; }
        IEnumerable<DiscountItem> DiscountItems { get; set; }
    }
}