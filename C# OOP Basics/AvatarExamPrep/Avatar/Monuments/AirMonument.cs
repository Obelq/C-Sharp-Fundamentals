
public class AirMonument : Monument
{
    public AirMonument(string name, int affinity)
        : base(name)
    {
        this.AirAffinity = affinity;
    }

    public int AirAffinity { get; set; }
    public override int GetAffinity()
    {
        return this.AirAffinity;
    }
    public override string ToString()
    {
        return $"Air {base.ToString()}, Air Affinity: {this.AirAffinity}";
    }
}
