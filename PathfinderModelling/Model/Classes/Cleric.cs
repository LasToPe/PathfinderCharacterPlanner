using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Cleric : CharacterClass
    {
        public Cleric()
        {
            Name = "Cleric";
            Alignment = "Within one step of her deity";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Aura", Level = 1 },
                new ClassAbility { Name = "Channel Energy 1d6", Level = 1 },
                new ClassAbility { Name = "Channel Energy 2d6", Level = 3 },
                new ClassAbility { Name = "Channel Energy 3d6", Level = 5 },
                new ClassAbility { Name = "Channel Energy 4d6", Level = 7 },
                new ClassAbility { Name = "Channel Energy 5d6", Level = 9 },
                new ClassAbility { Name = "Channel Energy 6d6", Level = 11 },
                new ClassAbility { Name = "Channel Energy 7d6", Level = 13 },
                new ClassAbility { Name = "Channel Energy 8d6", Level = 15 },
                new ClassAbility { Name = "Channel Energy 9d6", Level = 17 },
                new ClassAbility { Name = "Channel Energy 10d6", Level = 19 },
                new ClassAbility { Name = "Domains", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spontaneous Casting", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
            };
        }
    }
}
