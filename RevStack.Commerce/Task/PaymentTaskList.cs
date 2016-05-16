using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public class PaymentTaskList<TBag, TOrder, TPayment, TKey> : IPaymentTaskList<TBag, TOrder, TPayment, TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        public virtual List<IPaymentTask<TBag, TOrder, TPayment, TKey>> Tasks
        {
            get
            {
                return new List<IPaymentTask<TBag, TOrder, TPayment, TKey>>();
            }
        }
    }
}