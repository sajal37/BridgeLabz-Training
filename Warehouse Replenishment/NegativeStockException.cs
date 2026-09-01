using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Replenishment
{
    public class NegativeStockException : Exception
    {
        public string sku;
        public NegativeStockException(string sku)
        {
            this.sku = sku;
        }
    }
}
