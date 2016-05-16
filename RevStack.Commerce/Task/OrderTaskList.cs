using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public class OrderTaskList<TBag, TOrder, TPayment, TKey> : IOrderTaskList<TBag, TOrder, TPayment, TKey>
       where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        public virtual IEnumerable<IOrderTask<TBag, TOrder, TPayment, TKey>> Tasks
        {
            get
            {
                return new List<IOrderTask<TBag, TOrder, TPayment, TKey>>();
            }
        }
    }
}