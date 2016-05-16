using System;
using System.Collections.Generic;
using RevStack.Mvc;

namespace RevStack.Commerce
{
    
    public class Order<TKey> : IOrder<Payment,TKey>
    {
        public TKey Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public TKey UserId { get; set; }
        public bool IsAuthenticatedUser { get; set; }
        public string Email { get; set; }
        public IEnumerable<OrderItem<TKey>> Items { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public decimal Subtotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public string Notes { get; set; }
        public string TrackingUrl { get; set; }
        public virtual Payment Payment { get; set; }
        public IEnumerable<DiscountItem> DiscountItems { get; set; }
       
       
    }

    public class ApplicationOrder : Order<string>
    {
        public ApplicationOrder()
        {
            Id = Utils.GenerateRandomNumberString(Settings.OrderKeyLength);
        }
        public ApplicationOrder(bool isAuthenticated)
        {
            Id = Utils.GenerateRandomNumberString(Settings.OrderKeyLength);
            IsAuthenticatedUser = isAuthenticated;
        }
        public ApplicationOrder(bool isAuthenticated, string baseTrackingUrl)
        {
            Id = Utils.GenerateRandomNumberString(Settings.OrderKeyLength);
            IsAuthenticatedUser = isAuthenticated;
            TrackingUrl = baseTrackingUrl + Id.ToString();
        }
    }

    public class OrderItem<TKey> : ShoppingBagItem<TKey> { }

}