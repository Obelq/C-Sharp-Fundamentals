
using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester Get(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);
        switch (type)
        {
            case "Sonic":
                int sonicFactor = int.Parse(arguments[4]);
                Harvester sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                return sonicHarvester;
            case "Hammer":
                Harvester hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                return hammerHarvester;
            default:
                throw new InvalidOperationException();
        }
    }
}
