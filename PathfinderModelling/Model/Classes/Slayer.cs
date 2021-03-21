using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Slayer : CharacterClass
    {
        public Slayer()
        {
            Name = "Slayer";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "1st Studied Target", Level = 1 },
                new ClassAbility { Name = "2nd Studied Target", Level = 5 },
                new ClassAbility { Name = "3rd Studied Target", Level = 10 },
                new ClassAbility { Name = "4th Studied Target", Level = 15 },
                new ClassAbility { Name = "5th Studied Target", Level = 20 },
                new ClassAbility { Name = "Track", Level = 1 },
                new ClassAbility { Name = "Slayer Talent", Level = 2 },
                new ClassAbility { Name = "Slayer Talent", Level = 4 },
                new ClassAbility { Name = "Slayer Talent", Level = 6 },
                new ClassAbility { Name = "Slayer Talent", Level = 8 },
                new ClassAbility { Name = "Slayer Talent", Level = 10 },
                new ClassAbility { Name = "Slayer Talent", Level = 12 },
                new ClassAbility { Name = "Slayer Talent", Level = 14 },
                new ClassAbility { Name = "Slayer Talent", Level = 16 },
                new ClassAbility { Name = "Slayer Talent", Level = 18 },
                new ClassAbility { Name = "Slayer Talent", Level = 20 },
                new ClassAbility { Name = "Sneak Attack +1d6", Level = 3 },
                new ClassAbility { Name = "Sneak Attack +2d6", Level = 6 },
                new ClassAbility { Name = "Sneak Attack +3d6", Level = 9 },
                new ClassAbility { Name = "Sneak Attack +4d6", Level = 12 },
                new ClassAbility { Name = "Sneak Attack +5d6", Level = 15 },
                new ClassAbility { Name = "Sneak Attack +6d6", Level = 18 },
                new ClassAbility { Name = "Stalker", Level = 7 },
                new ClassAbility { Name = "Advanced Talents", Level = 10 },
                new ClassAbility { Name = "Swift Tracker", Level = 11 },
                new ClassAbility { Name = "Slayer's Advance 1/day", Level = 13 },
                new ClassAbility { Name = "Slayer's Advance 2/day", Level = 17 },
                new ClassAbility { Name = "Quarry", Level = 14 },
                new ClassAbility { Name = "Improved Quarry", Level = 19 },
                new ClassAbility { Name = "Master Slayer", Level = 20 },
            };
        }
    }
}
