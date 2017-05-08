using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSplit
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, long capacityConsumtion, long memoryConsumption) 
            : base(name, capacityConsumtion + capacityConsumtion/2, memoryConsumption - memoryConsumption/2)
        {
        }
    }
}