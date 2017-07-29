using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;
    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air", new Nation()},
            { "Fire", new Nation()},
            { "Earth", new Nation()},
            { "Water", new Nation()}

        };
        this.wars = new List<string>();
    }
    public void AssignBender(List<string> benderArgs)
    {
        var bender = this.GetBender(benderArgs);
        this.nations[benderArgs[0]].AddBender(bender);
    }

    private Bender GetBender(List<string> benderArgs)
    {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double boost = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                return new AirBender(name, power, boost);
            case "Fire":
                return new FireBender(name, power, boost);
            case "Earth":
                return new EarthBender(name, power, boost);
            case "Water":
                return new WaterBender(name, power, boost);
            default:
                throw new ArgumentException();
        }

    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monument = this.GetMonument(monumentArgs);
        this.nations[monumentArgs[0]].AddMonument(monument);
    }
    private Monument GetMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                return new AirMonument(name,  affinity);
            case "Fire":
                return new FireMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            default:
                throw new ArgumentException();
        }

    }
    public string GetStatus(string nationsType)
    {
        Nation nation = nations[nationsType];
        var result = new StringBuilder();
        result.AppendLine($"{nationsType} Nation")
            .Append("Benders:")
            .Append(nation.GetBendersToString())
            .Append($"{Environment.NewLine}Monuments:")
            .Append(nation.GetMonumentsToString());
        return result.ToString();


    }
    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var nationsScores = new Dictionary<string, double>();
        foreach (var nation in nations)
        {
            nationsScores.Add(nation.Key, nation.Value.GetTotalPower());
        }
        foreach (var nation in nationsScores.OrderByDescending(n => n.Value).Skip(1))
        {
            nations[nation.Key] = new Nation();
        }

    }
    public string GetWarsRecord()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.wars.Count; i++)
        {
            result.AppendLine($"War {i + 1} issued by {wars[i]}");
        }
        return result.ToString();
    }

}
