
using System.Collections.Generic;

public interface IRecipe
{
    string Name { get; set; }
    List<string> RequiredItems { get; set; }
    long StrengthBonus { get; set; }
    long AgilityBonus { get; set; }
    long IntelligenceBonus { get; set; }
    long HitPointsBonus { get; set; }
    long DamageBonus { get; set; }
}
