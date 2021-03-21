using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    class Witch : CharacterClass
    {
        public Witch()
        {
            Name = "Witch";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Hex", Level = 1 },
                new ClassAbility { Name = "Hex", Level = 2 },
                new ClassAbility { Name = "Hex", Level = 4 },
                new ClassAbility { Name = "Hex", Level = 6 },
                new ClassAbility { Name = "Hex", Level = 8 },
                new ClassAbility { Name = "Hex", Level = 10 },
                new ClassAbility { Name = "Hex", Level = 12 },
                new ClassAbility { Name = "Hex", Level = 14 },
                new ClassAbility { Name = "Hex", Level = 16 },
                new ClassAbility { Name = "Hex", Level = 18 },
                new ClassAbility { Name = "Hex", Level = 20 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Witch's Familiar", Level = 1 },
                new ClassAbility { Name = "Major Hex", Level = 10 },
                new ClassAbility { Name = "Grand Hex", Level = 18 },
            };
        }
    }
}
