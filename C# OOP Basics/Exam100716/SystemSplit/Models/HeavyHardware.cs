using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSplit
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, long maximumCapacity, long maximumMemory)
            : base(name, maximumCapacity * 2, maximumMemory - maximumMemory / 4)
        {
        }

        public override string HardwareType()
        {
            return "Heavy";
        }
    }
}