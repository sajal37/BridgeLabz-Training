using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Replenishment
{
    public class ReplenishmentEventArgs: EventArgs
    {
        public Reorder entry;
        public ReplenishmentEventArgs(Reorder entry)
        {
            this.entry = entry;
        }
    }
}