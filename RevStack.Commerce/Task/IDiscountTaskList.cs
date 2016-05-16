using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public interface IDiscountTaskList<TKey>
    {
        List<IDiscountTask<TKey>> Tasks { get; }
    }
}