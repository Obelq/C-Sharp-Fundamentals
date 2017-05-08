using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSplit
{
    public abstract class Software
    {
        private string name;
        private long capacityConsumtion;
        private long memoryConsumption;

        protected Software(string name, long capacityConsumtion, long memoryConsumption)
        {
            this.name = name;
            this.capacityConsumtion = capacityConsumtion;
            this.memoryConsumption = memoryConsumption;
        }

        public string Name { get { return this.name; }}
        public long CapacityConsumtion { get { return this.capacityConsumtion; } }
        public long MemoryConsumption { get { return this.memoryConsumption; } }
    }
}