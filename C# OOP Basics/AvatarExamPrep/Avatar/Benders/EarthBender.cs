
public class EarthBender : Bender
{
    public EarthBender(string name, int power, double boost)
        : base(name, power)
    {
        this.GroundSaturation = boost;
    }

    public double GroundSaturation { get; set; }
    public override double GetPower()
    {
        return this.GroundSaturation * this.Power;
    }
    public override string ToString()
    {
        return $"Earth {base.ToString()}, Ground Saturation: {this.GroundSaturation:F2}";
    }
}
