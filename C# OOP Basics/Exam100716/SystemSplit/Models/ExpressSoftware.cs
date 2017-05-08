using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSplit
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, long capacityConsumtion, long memoryConsumption) 
            : base(name, capacityConsumtion, memoryConsumption*2)
        {
        }
    }
}