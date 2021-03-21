using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Oracle : CharacterClass
    {
        public Oracle()
        {
            Name = "Oracle";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Mystery", Level = 1 },
                new ClassAbility { Name = "Oracle's Curse", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Revelation", Level = 1 },
                new ClassAbility { Name = "Revelation", Level = 3 },
                new ClassAbility { Name = "Revelation", Level = 7 },
                new ClassAbility { Name = "Revelation", Level = 11 },
                new ClassAbility { Name = "Revelation", Level = 15 },
                new ClassAbility { Name = "Revelation", Level = 19 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Mystery Spell", Level = 2 },
                new ClassAbility { Name = "Mystery Spell", Level = 4 },
                new ClassAbility { Name = "Mystery Spell", Level = 6 },
                new ClassAbility { Name = "Mystery Spell", Level = 8 },
                new ClassAbility { Name = "Mystery Spell", Level = 10 },
                new ClassAbility { Name = "Mystery Spell", Level = 12 },
                new ClassAbility { Name = "Mystery Spell", Level = 14 },
                new ClassAbility { Name = "Mystery Spell", Level = 16 },
                new ClassAbility { Name = "Mystery Spell", Level = 18 },
                new ClassAbility { Name = "Final Revelation", Level = 20 },
            };
        }
    }
}
