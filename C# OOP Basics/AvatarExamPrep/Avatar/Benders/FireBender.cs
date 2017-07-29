
public class FireBender : Bender
{
    public FireBender(string name, int power, double boost)
        : base(name, power)
    {
        this.HeatAggression = boost;
    }

    public double HeatAggression { get; set; }
    public override double GetPower()
    {
        return this.HeatAggression * this.Power;
    }
    public override string ToString()
    {
        return $"Fire {base.ToString()}, Heat Aggression: {this.HeatAggression:F2}";
    }
}
