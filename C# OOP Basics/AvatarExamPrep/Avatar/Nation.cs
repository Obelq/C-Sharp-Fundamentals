
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        var powerOfBenders = this.benders.Sum(b => b.GetPower());
        var totalAffinity = this.monuments.Sum(b => b.GetAffinity());
        var totalPower = powerOfBenders + powerOfBenders / 100 * totalAffinity;
        return totalPower;
    }

    public string GetBendersToString()
    {
        if (this.benders.Count == 0)
        {
            return " None";
        }

        StringBuilder result = new StringBuilder();
        foreach (var bender in this.benders)
        {
            result.Append($"{Environment.NewLine}###{bender}");
        }
        return result.ToString();

    }

    public string GetMonumentsToString()
    {
        if (this.monuments.Count == 0)
        {
            return " None";
        }

        StringBuilder result = new StringBuilder();
        foreach (var monument in this.monuments)
        {
            result.Append($"{Environment.NewLine}###{monument}");
        }
        return result.ToString();

    }

    public void AddBender(Bender bender)
    {
        benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        monuments.Add(monument);
    }
}
