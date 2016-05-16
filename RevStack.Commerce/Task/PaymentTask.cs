using System;
using System.Threading.Tasks;

namespace RevStack.Commerce
{
    public class PaymentTask<TBag, TOrder, TPayment, TKey> : IPaymentTask<TBag, TOrder, TPayment, TKey>
         where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        public virtual string PaymentType { get; set; }
        public virtual bool Approved { get; set; }
        public virtual Task<ITransaction<TBag, TOrder, TPayment, TKey>> RunAsync(ITransaction<TBag, TOrder, TPayment, TKey> transaction)
        {
            throw new NotImplementedException();
        }

        protected TPayment BuildProcessorDictionary(TPayment payment)
        {
            foreach (var item in payment.PaymentFields)
            {
                payment.ProcessorFields.Add(item.Key, item.Value);
            }

            return payment;
        }


        protected IPaymentProvider CreateClient(Type type)
        {
            return (IPaymentProvider)Activator.CreateInstance(type);
        }
    }
}