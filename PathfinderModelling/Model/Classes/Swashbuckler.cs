using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Swashbuckler : CharacterClass
    {
        public Swashbuckler()
        {
            Name = "Swashbuckler";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Deeds", Level = 1 },
                new ClassAbility { Name = "Deeds", Level = 3 },
                new ClassAbility { Name = "Deeds", Level = 7 },
                new ClassAbility { Name = "Deeds", Level = 11 },
                new ClassAbility { Name = "Deeds", Level = 15 },
                new ClassAbility { Name = "Deeds", Level = 19 },
                new ClassAbility { Name = "Panache", Level = 1 },
                new ClassAbility { Name = "Swashbuckler Finesse", Level = 1 },
                new ClassAbility { Name = "Charmed Life 3/day", Level = 2 },
                new ClassAbility { Name = "Charmed Life 4/day", Level = 6 },
                new ClassAbility { Name = "Charmed Life 5/day", Level = 10 },
                new ClassAbility { Name = "Charmed Life 6/day", Level = 14 },
                new ClassAbility { Name = "Charmed Life 7/day", Level = 18 },
                new ClassAbility { Name = "Nimble +1", Level = 3 },
                new ClassAbility { Name = "Nimble +2", Level = 7 },
                new ClassAbility { Name = "Nimble +3", Level = 11 },
                new ClassAbility { Name = "Nimble +4", Level = 15 },
                new ClassAbility { Name = "Nimble +5", Level = 19 },
                new ClassAbility { Name = "Bonus Feat", Level = 4 },
                new ClassAbility { Name = "Bonus Feat", Level = 8 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 16 },
                new ClassAbility { Name = "Bonus Feat", Level = 20 },
                new ClassAbility { Name = "Swashbuckler Weapon Training +1", Level = 5 },
                new ClassAbility { Name = "Swashbuckler Weapon Training +2", Level = 9 },
                new ClassAbility { Name = "Swashbuckler Weapon Training +3", Level = 13 },
                new ClassAbility { Name = "Swashbuckler Weapon Training +4", Level = 17 },
                new ClassAbility { Name = "Swashbuckler Weapon Mastery", Level = 20 },
            };
        }
    }
}
