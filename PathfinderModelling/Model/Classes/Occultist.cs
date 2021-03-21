using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Occultist : CharacterClass
    {
        public Occultist()
        {
            Name = "Occultist";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Focus Powers", Level = 1 },
                new ClassAbility { Name = "Implements 2", Level = 1 },
                new ClassAbility { Name = "Implements 3", Level = 2 },
                new ClassAbility { Name = "Implements 4", Level = 6 },
                new ClassAbility { Name = "Implements 5", Level = 10 },
                new ClassAbility { Name = "Implements 6", Level = 14 },
                new ClassAbility { Name = "Implements 7", Level = 18 },
                new ClassAbility { Name = "Knacks", Level = 1 },
                new ClassAbility { Name = "Mental Focus", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Magic Item Skill", Level = 2 },
                new ClassAbility { Name = "Object Reading", Level = 2 },
                new ClassAbility { Name = "Focus Power", Level = 3 },
                new ClassAbility { Name = "Focus Power", Level = 5 },
                new ClassAbility { Name = "Focus Power", Level = 7 },
                new ClassAbility { Name = "Focus Power", Level = 9 },
                new ClassAbility { Name = "Focus Power", Level = 11 },
                new ClassAbility { Name = "Focus Power", Level = 13 },
                new ClassAbility { Name = "Focus Power", Level = 15 },
                new ClassAbility { Name = "Focus Power", Level = 17 },
                new ClassAbility { Name = "Focus Power", Level = 19 },
                new ClassAbility { Name = "Shift Focus", Level = 4 },
                new ClassAbility { Name = "Aura Sight", Level = 5 },
                new ClassAbility { Name = "Magic Circles", Level = 8 },
                new ClassAbility { Name = "Outside Contact 1", Level = 8 },
                new ClassAbility { Name = "Outside Contact 2", Level = 12 },
                new ClassAbility { Name = "Outside Contact 3", Level = 16 },
                new ClassAbility { Name = "Outside Contact 4", Level = 20 },
                new ClassAbility { Name = "Binding Circles", Level = 12 },
                new ClassAbility { Name = "Fast Circles", Level = 16 },
                new ClassAbility { Name = "Implement Mastery", Level = 20 },
            };
        }
    }
}
