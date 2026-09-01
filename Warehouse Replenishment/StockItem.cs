using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Replenishment
{
    [StorageCondition("Refrigerated")]
    public class StockItem
    {
        public string sku;
        public int quantity;
        public string category;
        public StockItem(string sku, int quantity, string category)
        {
            this.sku=sku;
            this.quantity=quantity;
            this.category=category;
        }
    }
}