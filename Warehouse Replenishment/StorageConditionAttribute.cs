using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse_Replenishment
{
    [AttributeUsage(AttributeTargets.Class)]
    public class StorageConditionAttribute: Attribute
    {
        public string statement;
        public StorageConditionAttribute(string statement)
        {
            this.statement = statement;
        }
    }
}