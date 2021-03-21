using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class MonkUnchained : CharacterClass
    {
        public MonkUnchained()
        {
            Name = "Monk (Unchained)";
            Alignment = "Any lawful";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
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
                new ClassAbility { Name = "Flurry of Blows", Level = 11 },
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
                new ClassAbility { Name = "Ki Pool", Level = 3 },
                new ClassAbility { Name = "Ki Strike (magic)", Level = 3 },
                new ClassAbility { Name = "Ki Strike (cold iron/silver)", Level = 7 },
                new ClassAbility { Name = "Ki Strike (lawful)", Level = 10 },
                new ClassAbility { Name = "Ki Strike (adamantine)", Level = 16 },
                new ClassAbility { Name = "Still Mind", Level = 3 },
                new ClassAbility { Name = "Ki Power", Level = 4 },
                new ClassAbility { Name = "Ki Power", Level = 6 },
                new ClassAbility { Name = "Ki Power", Level = 8 },
                new ClassAbility { Name = "Ki Power", Level = 10 },
                new ClassAbility { Name = "Ki Power", Level = 12 },
                new ClassAbility { Name = "Ki Power", Level = 14 },
                new ClassAbility { Name = "Ki Power", Level = 16 },
                new ClassAbility { Name = "Ki Power", Level = 18 },
                new ClassAbility { Name = "Ki Power", Level = 20 },
                new ClassAbility { Name = "Purity of Body", Level = 5 },
                new ClassAbility { Name = "Style Strike 1/round", Level = 5 },
                new ClassAbility { Name = "Style Strike 2/round", Level = 15 },
                new ClassAbility { Name = "Improved Evasion", Level = 9 },
                new ClassAbility { Name = "Tongue of the Sun and Moon", Level = 13 },
                new ClassAbility { Name = "Timeless Body", Level = 17 },
                new ClassAbility { Name = "Flawless Mind", Level = 19 },
                new ClassAbility { Name = "Perfect Self", Level = 20 },
            };
        }
    }
}
