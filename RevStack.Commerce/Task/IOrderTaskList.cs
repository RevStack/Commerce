using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public interface IOrderTaskList<TBag, TOrder, TPayment, TKey>
       where TBag : class, IShoppingBag<TKey>
       where TOrder : class, IOrder<TPayment, TKey>
       where TPayment : class, IPayment
    {
        IEnumerable<IOrderTask<TBag, TOrder, TPayment, TKey>> Tasks { get; }
    }


}