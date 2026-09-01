using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Warehouse_Replenishment
{
    public class StockMonitor
    {
        Dictionary<string, StockItem> items = new Dictionary<string, StockItem>();
        public event EventHandler<ReplenishmentEventArgs> Event;
        public void Add(StockItem item)
        {
            items[item.sku] = item;
        }
        public Predicate<StockItem> CreateReorderRule(int reorderPoint)
        {
            return item => item.quantity > reorderPoint;
        }
        public void AdjustStock(string sku, int amount)
        {
            if (!items.ContainsKey(sku)) throw new KeyNotFoundException();
            items[sku].quantity += amount;
            if (items[sku].quantity < 0) throw new NegativeStockException(sku);
        }
        public void LogStock(StockItem item, Action<StockItem> act)
        {
            act(item);
        }
        public void RaiseReplenishment(StockItem item)
        {
            Reorder reorder = new Reorder();
            reorder.sku = item.sku;
            reorder.quantity = 10;
            Event?.Invoke(this, new ReplenishmentEventArgs(reorder));
        }
        public bool Refrigerated(StockItem item)
        {
            Type type1 = item.GetType();
            Type type2 = typeof(StorageConditionAttribute);
            return Attribute.GetCustomAttribute(type1, type2) != null;
        }
        public int LowestCategoryStock(IEnumerable<StockItem> list)
        {
            return list.GroupBy(item => item.category).Select(group => group.Sum(item => item.quantity)).Min();
        }
    }
}