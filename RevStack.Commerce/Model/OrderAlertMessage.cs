using System;
using RevStack.Notification;

namespace RevStack.Commerce
{
    public class OrderAlertMessage<TKey> : OrderMessage<TKey>,INotify<TKey>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}