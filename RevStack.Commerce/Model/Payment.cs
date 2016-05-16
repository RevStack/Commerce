using System;
using System.Collections.Generic;
using RevStack.Pattern;

namespace RevStack.Commerce
{
    public class Payment: IPayment
    {
        public string PaymentType { get; set; }
        public IEnumerable<KeyValueItem> UserFields { get; set; }
        public IEnumerable<KeyValueItem> PaymentFields { get; set; }
        public Dictionary<string, string> ProcessorFields { get; set; }
        public IEnumerable<KeyValueItem> ResponseFields { get; set; }
        public Payment()
        {
            UserFields = new List<KeyValueItem>();
            PaymentFields = new List<KeyValueItem>();
            ProcessorFields = new Dictionary<string, string>();
            ResponseFields = new List<KeyValueItem>();
        }
    }

    public class BillingAddress : Address { }

    public class PaymentOption : IEntity<string>
    {
        public string Id { get; set; }
        public string PaymentType { get; set; }
        public string ProcessorType { get; set; }
        public string PaymentTemplate { get; set; }

    }


}