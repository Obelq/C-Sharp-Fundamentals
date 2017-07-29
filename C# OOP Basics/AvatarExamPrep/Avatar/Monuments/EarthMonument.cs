
public class EarthMonument : Monument
{
    public EarthMonument(string name, int affinity)
        : base(name)
    {
        this.EarthAffinity = affinity;
    }

    public int EarthAffinity { get; set; }
    public override int GetAffinity()
    {
        return this.EarthAffinity;
    }
    public override string ToString()
    {
        return $"Earth {base.ToString()}, Earth Affinity: {this.EarthAffinity}";
    }
}
