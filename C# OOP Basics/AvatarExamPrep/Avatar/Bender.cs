
public abstract class Bender
{
    protected Bender(string name, int power)
    {
        Name = name;
        Power = power;
    }
    public string Name { get; set; }
    public int Power { get; set; }

    public abstract double GetPower();

    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}";
    }
}
