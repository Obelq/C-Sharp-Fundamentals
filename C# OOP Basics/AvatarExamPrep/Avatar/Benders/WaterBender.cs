
public class WaterBender : Bender
{
    public WaterBender(string name, int power, double boost)
        : base(name, power)
    {
        this.WaterClarity = boost;
    }

    public double WaterClarity { get; set; }
    public override double GetPower()
    {
        return this.WaterClarity * this.Power;
    }
    public override string ToString()
    {
        return $"Water {base.ToString()}, Water Clarity: {this.WaterClarity:F2}";
    }
}
