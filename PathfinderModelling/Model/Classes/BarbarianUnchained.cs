using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class BarbarianUnchained : CharacterClass
    {
        public BarbarianUnchained()
        {
            Name = "Barbarian (Unchained)";
            Alignment = "Any Nonlawful";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Fast Movement", Level = 1 },
                new ClassAbility { Name = "Rage", Level = 1 },
                new ClassAbility { Name = "Rage Power", Level = 2 },
                new ClassAbility { Name = "Rage Power", Level = 4 },
                new ClassAbility { Name = "Rage Power", Level = 6 },
                new ClassAbility { Name = "Rage Power", Level = 8 },
                new ClassAbility { Name = "Rage Power", Level = 10 },
                new ClassAbility { Name = "Rage Power", Level = 12 },
                new ClassAbility { Name = "Rage Power", Level = 14 },
                new ClassAbility { Name = "Rage Power", Level = 16 },
                new ClassAbility { Name = "Rage Power", Level = 18 },
                new ClassAbility { Name = "Rage Power", Level = 20 },
                new ClassAbility { Name = "Uncanny Dodge", Level = 2 },
                new ClassAbility { Name = "Danger Sense +1", Level = 3 },
                new ClassAbility { Name = "Danger Sense +2", Level = 6 },
                new ClassAbility { Name = "Danger Sense +3", Level = 9 },
                new ClassAbility { Name = "Danger Sense +4", Level = 12 },
                new ClassAbility { Name = "Danger Sense +5", Level = 15 },
                new ClassAbility { Name = "Danger Sense +6", Level = 18 },
                new ClassAbility { Name = "Improved Uncanny Dodge", Level = 5 },
                new ClassAbility { Name = "Damage Reduction 1/-", Level = 7 },
                new ClassAbility { Name = "Damage Reduction 2/-", Level = 10 },
                new ClassAbility { Name = "Damage Reduction 3/-", Level = 13 },
                new ClassAbility { Name = "Damage Reduction 4/-", Level = 16 },
                new ClassAbility { Name = "Damage Reduction 5/-", Level = 19 },
                new ClassAbility { Name = "Greater Rage", Level = 11 },
                new ClassAbility { Name = "Indomitable Will", Level = 14 },
                new ClassAbility { Name = "Tireless Rage", Level = 17 },
                new ClassAbility { Name = "Mighty Rage", Level = 20 },
            };
        }
    }
}
