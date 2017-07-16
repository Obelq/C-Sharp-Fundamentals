using System;


public abstract class Harvester : Worker
{
    private double oreOutput;
    private double energyRequirement;
    protected Harvester(string id, double oreOutput, double energyRequirement)
        :base(id)
    {
        OreOutput = oreOutput;
        EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
                
            }
            else
            {
                this.oreOutput = value;
            }

        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            else
            {
                this.energyRequirement = value;
            }
        }
    }

    public override string ToString()
    {
        return
            $"{this.GetType().Name.Substring(0, this.GetType().Name.Length - 9)} Harvester - {Id}{Environment.NewLine}Ore Output: {oreOutput}{Environment.NewLine}Energy Requirement: {EnergyRequirement}";
    }
}
