using System;
using System.Threading.Tasks;
using RevStack.Mvc;
using RevStack.Notification;

namespace RevStack.Commerce
{
    public interface IUserAlertMessageService<TKey>
    {
        AlertMessage<TKey> Get(NotifyAlert<TKey> entity, UriUtility uri);
        Task<AlertMessage<TKey>> GetAsync(NotifyAlert<TKey> entity, UriUtility uri);
    }
}