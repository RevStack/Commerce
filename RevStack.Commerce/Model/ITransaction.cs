using System;
using System.Collections.Generic;


namespace RevStack.Commerce
{
    public interface ITransaction<TBag, TOrder, TPayment, TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        TKey UserId { get; set; }
        TBag ShoppingBag { get; set; }
        TOrder Order { get; set; }
        List<ShippingMethod> ShippingMatrix { get; set; }
        BillingAddress BillingAddress { get; set; }
        ShippingAddress ShippingAddress { get; set; }
        TPayment Payment { get; set; }
        List<PaymentOption> PaymentOptions { get; set; }
        ShippingMethod ShippingMethod { get; set; }
        string TrackingUrl { get; set; }
        bool Approved { get; set; }
        string Notes { get; set; }
    }

}