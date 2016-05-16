using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace RevStack.Commerce
{
    public interface IPaymentProvider
    {
        bool Approved { get; set; }
        IEnumerable<KeyValueItem> Charge(IAddress billingAddress, IAddress shippingAddress, Dictionary<string, string> fields, decimal total);
        Task<IEnumerable<KeyValueItem>> ChargeAsync(IAddress billingAddress, IAddress shippingAddress, Dictionary<string, string> fields, decimal total);
    }
}