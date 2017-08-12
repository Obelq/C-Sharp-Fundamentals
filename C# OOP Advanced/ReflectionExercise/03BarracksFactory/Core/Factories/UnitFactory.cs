


using System;

public class UnitFactory : IUnitFactory
{
    public IUnit CreateUnit(string unitType)
    {
        switch (unitType)
        {
            case "Swordsman":
                var swordsmanClass = typeof(Swordsman);
                Unit swordsman = Activator.CreateInstance(swordsmanClass, new object[0]) as Swordsman;
                return swordsman;
            case "Archer":
                var archerClass = typeof(Archer);
                Unit archer = Activator.CreateInstance(archerClass, new object[0]) as Archer;
                return archer;
            case "Pikeman":
                var pikemanClass = typeof(Pikeman);
                Unit pikeman = Activator.CreateInstance(pikemanClass, new object[0]) as Pikeman;
                return pikeman;
            case "Gunner":
                var gunnerClass = typeof(Gunner);
                Unit gunner = Activator.CreateInstance(gunnerClass, new object[0]) as Gunner;
                return gunner;
            case "Horseman":
                var horsemanClass = typeof(Horseman);
                Unit horseman = Activator.CreateInstance(horsemanClass, new object[0]) as Horseman;
                return horseman;
            default:
                throw new ArgumentException();
        }
    }
}

