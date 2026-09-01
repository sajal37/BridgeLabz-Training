using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Replenishment
{
    public class Reorder
    {
        public string sku { get; set; }
        public int quantity { get; set; }
        public bool inStock { get; set; }
    }
}
