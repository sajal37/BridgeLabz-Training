using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Warehouse_Replenishment
{
    [AttributeUsage(AttributeTargets.Class)]
    public class StorageConditionAttribute: Attribute
    {
        public string HighPriority;
        public StorageConditionAttribute(string HighPriority)
        {
            this.HighPriority = HighPriority;
        }
    }
}
