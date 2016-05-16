using System;

namespace RevStack.Commerce
{
    public interface IOrderTask<TBag,TOrder,TPayment,TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        OrderTaskType TaskType { get; set; }
        ITransaction<TBag, TOrder, TPayment, TKey> Run(ITransaction<TBag, TOrder, TPayment, TKey> transaction,bool isAuthenticated);
    }

    public enum OrderTaskType
    {
        Order,
        Tax,
        Notify,
        PaymentOption,
        ShippingMethod
    }
}