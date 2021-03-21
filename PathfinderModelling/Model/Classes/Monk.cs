using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Monk : CharacterClass
    {
        public Monk()
        {
            Name = "Monk";
            Alignment = "Any lawful";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "AC Bonus (wis)", Level = 1 },
                new ClassAbility { Name = "AC Bonus +1", Level = 4 },
                new ClassAbility { Name = "AC Bonus +2", Level = 8 },
                new ClassAbility { Name = "AC Bonus +3", Level = 12 },
                new ClassAbility { Name = "AC Bonus +4", Level = 16 },
                new ClassAbility { Name = "AC Bonus +5", Level = 20 },
                new ClassAbility { Name = "Bonus Feat", Level = 1 },
                new ClassAbility { Name = "Bonus Feat", Level = 2 },
                new ClassAbility { Name = "Bonus Feat", Level = 6 },
                new ClassAbility { Name = "Bonus Feat", Level = 10 },
                new ClassAbility { Name = "Bonus Feat", Level = 14 },
                new ClassAbility { Name = "Bonus Feat", Level = 18 },
                new ClassAbility { Name = "Flurry of Blows", Level = 1 },
                new ClassAbility { Name = "Stunning Fist", Level = 1 },
                new ClassAbility { Name = "Unarmed Strike 1d6", Level = 1 },
                new ClassAbility { Name = "Unarmed Strike 1d8", Level = 4 },
                new ClassAbility { Name = "Unarmed Strike 1d10", Level = 8 },
                new ClassAbility { Name = "Unarmed Strike 2d6", Level = 12 },
                new ClassAbility { Name = "Unarmed Strike 2d8", Level = 16 },
                new ClassAbility { Name = "Unarmed Strike 2d10", Level = 20 },
                new ClassAbility { Name = "Evasion", Level = 2 },
                new ClassAbility { Name = "Fast Movement +10 ft.", Level = 3 },
                new ClassAbility { Name = "Fast Movement +20 ft.", Level = 6 },
                new ClassAbility { Name = "Fast Movement +30 ft.", Level = 9 },
                new ClassAbility { Name = "Fast Movement +40 ft.", Level = 12 },
                new ClassAbility { Name = "Fast Movement +50 ft.", Level = 15 },
                new ClassAbility { Name = "Fast Movement +60 ft.", Level = 18 },
                new ClassAbility { Name = "Maneuver Training", Level = 3 },
                new ClassAbility { Name = "Still Mind", Level = 3 },
                new ClassAbility { Name = "Ki Pool (magic)", Level = 4 },
                new ClassAbility { Name = "Ki Pool (cold iron/silver)", Level = 7 },
                new ClassAbility { Name = "Ki Pool (lawful)", Level = 10 },
                new ClassAbility { Name = "Ki Pool (adamantine)", Level = 16 },
                new ClassAbility { Name = "Slow Fall 20 ft.", Level = 4 },
                new ClassAbility { Name = "Slow Fall 30 ft.", Level = 6 },
                new ClassAbility { Name = "Slow Fall 40 ft.", Level = 8 },
                new ClassAbility { Name = "Slow Fall 50 ft.", Level = 10 },
                new ClassAbility { Name = "Slow Fall 60 ft.", Level = 12 },
                new ClassAbility { Name = "Slow Fall 70 ft.", Level = 14 },
                new ClassAbility { Name = "Slow Fall 80 ft.", Level = 16 },
                new ClassAbility { Name = "Slow Fall 90 ft.", Level = 18 },
                new ClassAbility { Name = "Slow Fall Any Distance", Level = 20 },
                new ClassAbility { Name = "High Jump", Level = 5 },
                new ClassAbility { Name = "Purity of Body", Level = 5 },
                new ClassAbility { Name = "Wholeness of Body", Level = 7 },
                new ClassAbility { Name = "Improved Evasion", Level = 9 },
                new ClassAbility { Name = "Diamond Body", Level = 11 },
                new ClassAbility { Name = "Abundant Step", Level = 12 },
                new ClassAbility { Name = "Diamond Soul", Level = 13 },
                new ClassAbility { Name = "Quivering Palm", Level = 15 },
                new ClassAbility { Name = "Timeless Body", Level = 17 },
                new ClassAbility { Name = "Tongue of the Sun and Moon", Level = 17 },
                new ClassAbility { Name = "Empty Body", Level = 19 },
                new ClassAbility { Name = "Perfect Self", Level = 20 },
            };
        }
    }
}
