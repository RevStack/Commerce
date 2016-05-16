using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public class OrderStatus
    {
        public CurrentOrderStatus Status { get; set; }
        public List<OrderNotification> Notifications { get; set; }
    }

    public enum CurrentOrderStatus
    {
        Open,
        Closed,
        Completed,
        Pending,
        Processing,
        Processed,
        Cancelled,
        Charged,
        Authorized,
        Recurring,
        Routed,
        Refunded,
        Returned,
        Delivered,
        PaymentDue,
        Current,
        Failed,
        Expired,
        AwaitingPayment,
        Subscribed,
        Shipped,
        Other
    }
}