
public abstract class Monument
{
    protected Monument(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public abstract int GetAffinity();

    public override string ToString()
    {
        return $"Monument: {this.Name}";
    }
}
