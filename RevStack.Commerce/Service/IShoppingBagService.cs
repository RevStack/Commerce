using System;
using System.Threading.Tasks;


namespace RevStack.Commerce
{
    public interface IShoppingBagService<TBag, TKey>
        where TBag : class, IShoppingBag<TKey>
    {
        TBag Get(TKey id);
        Task<TBag> GetAsync(TKey id);
        ShoppingBagItem<TKey> AddItem(TKey id, ShoppingBagItem<TKey> item);
        Task<ShoppingBagItem<TKey>> AddItemAsync(TKey id, ShoppingBagItem<TKey> item);
        ShoppingBagItem<TKey> UpdateItem(TKey id, ShoppingBagItem<TKey> item);
        Task<ShoppingBagItem<TKey>> UpdateItemAsync(TKey id, ShoppingBagItem<TKey> item);
        TBag Update(TBag bag);
        Task<TBag> UpdateAsync(TBag bag);
        bool RemoveItem(TKey id, TKey itemId);
        Task<bool> RemoveItemAsync(TKey id, TKey itemId);
        bool Empty(TKey id);
        Task<bool> EmptyAsync(TKey id);
        int GetCount(TKey id);
        Task<int> GetCountAsync(TKey id);
        bool Move(TKey id, TKey oldId);
        Task<bool> MoveAsync(TKey id, TKey oldId);
    }
}