public class AirBender : Bender
{
    public AirBender(string name, int power, double boost)
        : base(name, power)
    {
        this.AerialIntegrity = boost;
    }

    public double AerialIntegrity { get; set; }

    public override double GetPower()
    {
        return this.AerialIntegrity * this.Power;
    }

    public override string ToString()
    {
        return $"Air {base.ToString()}, Aerial Integrity: {this.AerialIntegrity:F2}";
    }
}
