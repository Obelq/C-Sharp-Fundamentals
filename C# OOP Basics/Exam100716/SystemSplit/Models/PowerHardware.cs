using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSplit
{
    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, long maximumCapacity, long maximumMemory)
            : base(name, maximumCapacity - maximumCapacity * 3 / 4, maximumMemory + maximumMemory * 3 / 4)
        {
        }

        public override string HardwareType()
        {
            return "Power";
        }
    }
}