using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider Get(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        switch (type)
        {
            case "Solar":
                Provider solarProvider = new SolarProvider(id, energyOutput);
                return solarProvider;
            case "Pressure":
                Provider pressureProvider = new PressureProvider(id, energyOutput);
                return pressureProvider;
            default:
                throw new InvalidOperationException();
        }
    }
}