using System;
using System.Collections.Generic;
using System.Linq;


public class DraftManager
{
    private double totalMinedOre = 0;
    private double totalStoredEnergy = 0;
    private string mode = "Full";
    private Dictionary<string, Worker> workers = new Dictionary<string, Worker>();
    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        try
        {
            Harvester harvester = HarvesterFactory.Get(arguments);
            workers.Add(harvester.Id, harvester);
            return $"Successfully registered {type} Harvester - {harvester.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        try
        {
            Provider provider = ProviderFactory.Get(arguments);
            workers.Add(provider.Id, provider);
            return $"Successfully registered {type} Provider - {provider.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
    public string Day()
    {
        var newEnergy = workers.Values.OfType<Provider>().Sum(p => p.EnergyOutput);
        totalStoredEnergy += newEnergy;
        string result = $"A day has passed.{Environment.NewLine}Energy Provided: {newEnergy}{Environment.NewLine}";
        if (mode == "Full")
        {
            var energyNeeded = workers.Values.OfType<Harvester>().Sum(h => h.EnergyRequirement);
            if (energyNeeded > totalStoredEnergy)
            {
                return result + "Plumbus Ore Mined: 0";
            }
            totalStoredEnergy -= energyNeeded;
            var minedOre =  workers.Values.OfType<Harvester>().Sum(h => h.OreOutput);
            totalMinedOre += minedOre;
            return result + $"Plumbus Ore Mined: {minedOre}";
        }
        else if (mode == "Half")
        {
            var energyNeeded = workers.Values.OfType<Harvester>().Sum(h => h.EnergyRequirement) * 0.6;
            if (energyNeeded > totalStoredEnergy)
            {
                return result + "Plumbus Ore Mined: 0";
            }
            totalStoredEnergy -= energyNeeded;
            var minedOre = workers.Values.OfType<Harvester>().Sum(h => h.OreOutput) * 0.5;
            totalMinedOre += minedOre;
            return result + $"Plumbus Ore Mined: {minedOre}";
        }
        else
        {
            return result + "Plumbus Ore Mined: 0";
        }
    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (workers.ContainsKey(id))
        {
            return workers[id].ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        return
            $"System Shutdown{Environment.NewLine}Total Energy Stored: {totalStoredEnergy}{Environment.NewLine}Total Mined Plumbus Ore: {totalMinedOre}";
    }


}
