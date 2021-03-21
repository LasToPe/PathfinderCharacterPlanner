using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Rogue : CharacterClass
    {
        public Rogue()
        {
            Name = "Rogue";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Finesse Training", Level = 1 },
                new ClassAbility { Name = "Finesse Training", Level = 3 },
                new ClassAbility { Name = "Finesse Training", Level = 11 },
                new ClassAbility { Name = "Finesse Training", Level = 19 },
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
                new ClassAbility { Name = "Trapfinding", Level = 1 },
                new ClassAbility { Name = "Evasion", Level = 2 },
                new ClassAbility { Name = "Rogue Talent", Level = 2 },
                new ClassAbility { Name = "Rogue Talent", Level = 4 },
                new ClassAbility { Name = "Rogue Talent", Level = 6 },
                new ClassAbility { Name = "Rogue Talent", Level = 8 },
                new ClassAbility { Name = "Rogue Talent", Level = 10 },
                new ClassAbility { Name = "Rogue Talent", Level = 12 },
                new ClassAbility { Name = "Rogue Talent", Level = 14 },
                new ClassAbility { Name = "Rogue Talent", Level = 16 },
                new ClassAbility { Name = "Rogue Talent", Level = 18 },
                new ClassAbility { Name = "Rogue Talent", Level = 20 },
                new ClassAbility { Name = "Danger Sense +1", Level = 3 },
                new ClassAbility { Name = "Danger Sense +2", Level = 6 },
                new ClassAbility { Name = "Danger Sense +3", Level = 9 },
                new ClassAbility { Name = "Danger Sense +4", Level = 12 },
                new ClassAbility { Name = "Danger Sense +5", Level = 15 },
                new ClassAbility { Name = "Danger Sense +6", Level = 18 },
                new ClassAbility { Name = "Debilitating Injury", Level = 4 },
                new ClassAbility { Name = "Uncanny Dodge", Level = 4 },
                new ClassAbility { Name = "Rogue's Edge", Level = 5 },
                new ClassAbility { Name = "Rogue's Edge", Level = 10 },
                new ClassAbility { Name = "Rogue's Edge", Level = 15 },
                new ClassAbility { Name = "Rogue's Edge", Level = 20 },
                new ClassAbility { Name = "Improved Uncanny Dodge", Level = 8 },
                new ClassAbility { Name = "Advanced Talents", Level = 10 },
                new ClassAbility { Name = "Master Strike", Level = 20 },
            };
        }
    }
}
