using System;

namespace RevStack.Commerce
{
    public class OrderTask<TBag, TOrder, TPayment, TKey> : IOrderTask<TBag, TOrder, TPayment, TKey>
        where TBag : class, IShoppingBag<TKey>
         where TOrder : class, IOrder<TPayment, TKey>
         where TPayment : class, IPayment
    {
        private OrderTaskType _taskType;
        public OrderTaskType TaskType
        {
            get
            {
                return _taskType;
            }

            set
            {
                _taskType = value;
            }
        }

        public virtual ITransaction<TBag, TOrder, TPayment, TKey> Run(ITransaction<TBag, TOrder, TPayment, TKey> transaction, bool isAuthenticated)
        {
            throw new NotImplementedException();
        }
    }
}