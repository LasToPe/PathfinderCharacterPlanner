using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Fighter : CharacterClass
    {
        public Fighter()
        {
            Name = "Fighter";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bonus Feat", Level = 1 },
                new ClassAbility { Name = "Bonus Feat", Level = 2 },
                new ClassAbility { Name = "Bonus Feat", Level = 4 },
                new ClassAbility { Name = "Bonus Feat", Level = 6 },
                new ClassAbility { Name = "Bonus Feat", Level = 8 },
                new ClassAbility { Name = "Bonus Feat", Level = 10 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 14 },
                new ClassAbility { Name = "Bonus Feat", Level = 16 },
                new ClassAbility { Name = "Bonus Feat", Level = 18 },
                new ClassAbility { Name = "Bonus Feat", Level = 20 },
                new ClassAbility { Name = "Bravery +1", Level = 2 },
                new ClassAbility { Name = "Bravery +2", Level = 6 },
                new ClassAbility { Name = "Bravery +3", Level = 10 },
                new ClassAbility { Name = "Bravery +4", Level = 14 },
                new ClassAbility { Name = "Bravery +5", Level = 18 },
                new ClassAbility { Name = "Armor Training 1", Level = 3 },
                new ClassAbility { Name = "Armor Training 2", Level = 7 },
                new ClassAbility { Name = "Armor Training 3", Level = 11 },
                new ClassAbility { Name = "Armor Training 4", Level = 15 },
                new ClassAbility { Name = "Armor Mastery", Level = 19 },
                new ClassAbility { Name = "Weapon Training 1", Level = 5 },
                new ClassAbility { Name = "Weapon Training 2", Level = 9 },
                new ClassAbility { Name = "Weapon Training 3", Level = 13 },
                new ClassAbility { Name = "Weapon Training 4", Level = 17 },
                new ClassAbility { Name = "Weapon Mastery", Level = 20 },
            };
        }
    }
}
