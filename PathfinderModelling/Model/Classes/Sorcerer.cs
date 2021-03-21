using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    class Sorcerer : CharacterClass
    {
        public Sorcerer()
        {
            Name = "Sorcerer";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bloodline", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 3 },
                new ClassAbility { Name = "Bloodline Power", Level = 9 },
                new ClassAbility { Name = "Bloodline Power", Level = 15 },
                new ClassAbility { Name = "Bloodline Power", Level = 20 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Eschew Materials", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Bloodline Spell", Level = 3 },
                new ClassAbility { Name = "Bloodline Spell", Level = 5 },
                new ClassAbility { Name = "Bloodline Spell", Level = 7 },
                new ClassAbility { Name = "Bloodline Spell", Level = 9 },
                new ClassAbility { Name = "Bloodline Spell", Level = 11 },
                new ClassAbility { Name = "Bloodline Spell", Level = 13 },
                new ClassAbility { Name = "Bloodline Spell", Level = 15 },
                new ClassAbility { Name = "Bloodline Spell", Level = 17 },
                new ClassAbility { Name = "Bloodline Spell", Level = 19 },
                new ClassAbility { Name = "Bloodline Feat", Level = 7 },
                new ClassAbility { Name = "Bloodline Feat", Level = 13 },
                new ClassAbility { Name = "Bloodline Feat", Level = 19 },
            };
        }
    }
}
