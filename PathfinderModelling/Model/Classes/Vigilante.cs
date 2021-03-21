using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Vigilante : CharacterClass
    {
        public Vigilante()
        {
            Name = "Vigilante";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Dual Identity", Level = 1 },
                new ClassAbility { Name = "Seamless Guise", Level = 1 },
                new ClassAbility { Name = "Social Talent", Level = 1 },
                new ClassAbility { Name = "Social Talent", Level = 3 },
                new ClassAbility { Name = "Social Talent", Level = 5 },
                new ClassAbility { Name = "Social Talent", Level = 7 },
                new ClassAbility { Name = "Social Talent", Level = 9 },
                new ClassAbility { Name = "Social Talent", Level = 11 },
                new ClassAbility { Name = "Social Talent", Level = 13 },
                new ClassAbility { Name = "Social Talent", Level = 15 },
                new ClassAbility { Name = "Social Talent", Level = 17 },
                new ClassAbility { Name = "Social Talent", Level = 19 },
                new ClassAbility { Name = "Vigilante Specialization", Level = 1 },
                new ClassAbility { Name = "Vigilante Talent", Level = 2 },
                new ClassAbility { Name = "Vigilante Talent", Level = 4 },
                new ClassAbility { Name = "Vigilante Talent", Level = 6 },
                new ClassAbility { Name = "Vigilante Talent", Level = 8 },
                new ClassAbility { Name = "Vigilante Talent", Level = 10 },
                new ClassAbility { Name = "Vigilante Talent", Level = 12 },
                new ClassAbility { Name = "Vigilante Talent", Level = 14 },
                new ClassAbility { Name = "Vigilante Talent", Level = 16 },
                new ClassAbility { Name = "Vigilante Talent", Level = 18 },
                new ClassAbility { Name = "Vigilante Talent", Level = 20 },
                new ClassAbility { Name = "Unshakable", Level = 3 },
                new ClassAbility { Name = "Startling Appearance", Level = 5 },
                new ClassAbility { Name = "Frightening Appearance", Level = 11 },
                new ClassAbility { Name = "Stunning Appearance", Level = 17 },
                new ClassAbility { Name = "Vengeance Strike", Level = 20 },
            };
        }
    }
}
