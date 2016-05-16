using System;
using System.Threading.Tasks;

namespace RevStack.Commerce
{
    public interface ITransactionService<TBag, TOrder, TPayment, TDiscount, TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
         where TDiscount : class, IDiscount
    {
        Task<ITransaction<TBag, TOrder, TPayment, TKey>> GetAsync(TKey id);
        ITransaction<TBag, TOrder, TPayment, TKey> Post(ITransaction<TBag, TOrder, TPayment, TKey> transaction);
        Task<ITransaction<TBag, TOrder, TPayment, TKey>> PostAsync(ITransaction<TBag, TOrder, TPayment, TKey> transaction);
    }
}