using System;
using RevStack.Pattern;
using RevStack.Notification;

namespace RevStack.Commerce
{
    public class OrderMessage<TKey> : IEntity<TKey>,IMessage
    {
        public TKey Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string ShipMessage { get; set; }
        public string ShippingName { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public string Total { get; set; }
        public string MainItem { get; set; }
        public string ItemText { get; set; }
        public int ItemCount { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public string TrackingUrl { get; set; }
        public string TrackingLabel { get; set; }
        public string Company { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string CssHightlightColor { get; set; }
        public string CssLinkColor { get; set; }
    }
}