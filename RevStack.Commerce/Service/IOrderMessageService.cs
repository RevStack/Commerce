using System;
using System.Threading.Tasks;
using RevStack.Mvc;

namespace RevStack.Commerce
{
    public interface IOrderMessageService<TOrder,TPayment, TKey>
        where TOrder : class, IOrder<TPayment, TKey>
        where TPayment : class, IPayment
    {
        OrderMessage<TKey> Get(TKey id,UriUtility uri);
        Task<OrderMessage<TKey>> GetAsync(TKey id,UriUtility uri);
    }
}