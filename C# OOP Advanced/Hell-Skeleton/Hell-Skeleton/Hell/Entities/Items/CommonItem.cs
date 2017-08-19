public class CommonItem : IItem
{
    private string name;
    private long strengthBonus;
    private long agilityBonus;
    private long intelligenceBonus;
    private long hitPointsBonus;
    private long damageBonus;

    public CommonItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public long DamageBonus { get; set; }

    public long HitPointsBonus { get; set; }

    public long IntelligenceBonus { get; set; }

    public long AgilityBonus { get; set; }

    public long StrengthBonus { get; set; }

    public string Name { get; set; }
}
