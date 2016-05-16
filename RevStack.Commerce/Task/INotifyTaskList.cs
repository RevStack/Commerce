using System;
using System.Collections.Generic;

namespace RevStack.Commerce
{
    public interface INotifyTaskList<TKey>
    {
        List<INotifyTask<TKey>> Tasks { get; }
    }
}