using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Ninja : CharacterClass
    {
        public Ninja()
        {
            Name = "Ninja";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Poison Use", Level = 1 },
                new ClassAbility { Name = "Sneak Attack +1d6", Level = 1 },
                new ClassAbility { Name = "Sneak Attack +2d6", Level = 3 },
                new ClassAbility { Name = "Sneak Attack +3d6", Level = 5 },
                new ClassAbility { Name = "Sneak Attack +4d6", Level = 7 },
                new ClassAbility { Name = "Sneak Attack +5d6", Level = 9 },
                new ClassAbility { Name = "Sneak Attack +6d6", Level = 11 },
                new ClassAbility { Name = "Sneak Attack +7d6", Level = 13 },
                new ClassAbility { Name = "Sneak Attack +8d6", Level = 15 },
                new ClassAbility { Name = "Sneak Attack +9d6", Level = 17 },
                new ClassAbility { Name = "Sneak Attack +10d6", Level = 19 },
                new ClassAbility { Name = "Ki Pool", Level = 2 },
                new ClassAbility { Name = "Ninja Trick", Level = 2 },
                new ClassAbility { Name = "Ninja Trick", Level = 4 },
                new ClassAbility { Name = "Ninja Trick", Level = 6 },
                new ClassAbility { Name = "Ninja Trick", Level = 8 },
                new ClassAbility { Name = "Ninja Trick", Level = 10 },
                new ClassAbility { Name = "Ninja Trick", Level = 12 },
                new ClassAbility { Name = "Ninja Trick", Level = 14 },
                new ClassAbility { Name = "Ninja Trick", Level = 16 },
                new ClassAbility { Name = "Ninja Trick", Level = 18 },
                new ClassAbility { Name = "Ninja Trick", Level = 20 },
                new ClassAbility { Name = "No Trace", Level = 3 },
                new ClassAbility { Name = "Uncanny Dodge", Level = 4 },
                new ClassAbility { Name = "Light Steps", Level = 6 },
                new ClassAbility { Name = "Improved Uncanny Dodge", Level = 8 },
                new ClassAbility { Name = "Master Tricks", Level = 10 },
                new ClassAbility { Name = "Hidden Master", Level = 20 },
            };
        }
    }
}
