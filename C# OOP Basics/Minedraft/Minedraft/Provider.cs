using System;

public abstract class Provider : Worker
{
    private double energyOutput;
    protected Provider(string id, double energyOutput)
        :base(id)
    {
        EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get
        {
            return energyOutput;
        }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            else
            {
                this.energyOutput = value;
            }
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name.Substring(0, this.GetType().Name.Length - 8)} Provider - {Id}{Environment.NewLine}Energy Output: {energyOutput}";
    }
}
