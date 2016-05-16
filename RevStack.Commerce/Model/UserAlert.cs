using System;


namespace RevStack.Commerce
{
    public class UserAlert<TKey> : KeyValueItem,INotify<TKey>
    {
        public TKey Id { get; set; }
        public DateTime Date { get; set; }
        public string TrackingUrl { get; set; }
        public string TrackingLabel { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}