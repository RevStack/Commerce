using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public class Transaction<TBag,TOrder,TPayment,TKey> :ITransaction<TBag,TOrder,TPayment,TKey>
        where TBag : class, IShoppingBag<TKey>
        where TOrder : class, IOrder<TPayment,TKey>
        where TPayment : class, IPayment
    {
        public Transaction()
        {
            ShippingMatrix = new List<ShippingMethod>();
            BillingAddress = new BillingAddress();
            ShippingAddress = new ShippingAddress();
            ShippingMethod = new ShippingMethod();
            Approved = false;
        }

        public TKey UserId { get; set; }
        public TBag ShoppingBag { get; set; }
        public TOrder Order { get; set; }
        public List<ShippingMethod> ShippingMatrix { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public TPayment Payment { get; set; }
        public List<PaymentOption> PaymentOptions { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public string TrackingUrl { get; set; }
        public bool Approved { get; set; }
        public string Notes { get; set; }
    }


}