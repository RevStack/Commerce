using System;
using RevStack.Notification;

namespace RevStack.Commerce
{
    public class UserAlertMessage<TKey> : NotifyAlert<TKey>,IMessage
    {
        public string Day { get; set; }
        public string Company { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string CssHightlightColor { get; set; }
        public string CssLinkColor { get; set; }
    }
}