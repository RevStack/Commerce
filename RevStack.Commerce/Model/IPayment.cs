using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public interface IPayment
    {
        string PaymentType { get; set; } //payment type id. e.g. CreditCard,PayPal,ApplePay
        IEnumerable<KeyValueItem> UserFields { get; set; } //ienumerable list of fields for user UI presentation, e.g, user cardOnFile
        IEnumerable<KeyValueItem> PaymentFields { get; set; }  //ienumerable payment submission fields
        Dictionary<string, string> ProcessorFields { get; set; } //fields converted to a dictionary collection
        IEnumerable<KeyValueItem> ResponseFields { get; set; } //ienumerable result fields from payment gateway
    }
}