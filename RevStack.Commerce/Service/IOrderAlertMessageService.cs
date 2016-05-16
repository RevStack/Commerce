using System;
using System.Threading.Tasks;
using RevStack.Mvc;
using RevStack.Notification;

namespace RevStack.Commerce
{
    public interface IOrderAlertMessageService<TOrder, TPayment, TKey>
        where TOrder : class, IOrder<TPayment, TKey>
        where TPayment : class, IPayment
    {
        OrderAlertMessage<TKey> Get(NotifyAlert<TKey> entity, UriUtility uri);
        Task<OrderAlertMessage<TKey>> GetAsync(NotifyAlert<TKey> entity, UriUtility uri);
    }
   
}