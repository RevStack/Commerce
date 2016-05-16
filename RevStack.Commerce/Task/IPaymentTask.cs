using System;
using System.Threading.Tasks;

namespace RevStack.Commerce
{
    
    public interface IPaymentTask<TBag, TOrder, TPayment, TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        string PaymentType { get; set; }
        bool Approved { get; set; }
        Task<ITransaction<TBag, TOrder, TPayment, TKey>> RunAsync(ITransaction<TBag, TOrder, TPayment, TKey> transaction);
    }

   
}