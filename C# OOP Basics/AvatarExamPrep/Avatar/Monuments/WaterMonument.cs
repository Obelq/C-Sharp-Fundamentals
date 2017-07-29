
public class WaterMonument : Monument
{
    public WaterMonument(string name, int affinity)
        : base(name)
    {
        this.WaterAffinity = affinity;
    }

    public int WaterAffinity { get; set; }
    public override int GetAffinity()
    {
        return this.WaterAffinity;
    }
    public override string ToString()
    {
        return $"Water {base.ToString()}, Water Affinity: {this.WaterAffinity}";
    }
}
