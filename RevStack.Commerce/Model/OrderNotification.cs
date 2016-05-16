using System;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public class OrderNotification : KeyValueItem
    {
        public DateTime Date { get; set; }
    }

    /*public class OrderNotificationEntity<TKey> : OrderNotification,IEntity<TKey>
    {
        public TKey Id { get; set; }
    }*/
}