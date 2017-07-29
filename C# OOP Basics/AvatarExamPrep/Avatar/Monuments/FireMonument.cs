
public class FireMonument : Monument
{
    public FireMonument(string name, int affinity)
        : base(name)
    {
        this.FireAffinity = affinity;
    }

    public int FireAffinity { get; set; }
    public override int GetAffinity()
    {
        return this.FireAffinity;
    }
    public override string ToString()
    {
        return $"Fire {base.ToString()}, Fire Affinity: {this.FireAffinity}";
    }
}
