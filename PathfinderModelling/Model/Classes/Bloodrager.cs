using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Bloodrager : CharacterClass
    {
        public Bloodrager()
        {
            Name = "Bloodrager";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bloodline", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 4 },
                new ClassAbility { Name = "Bloodline Power", Level = 8 },
                new ClassAbility { Name = "Bloodline Power", Level = 12 },
                new ClassAbility { Name = "Bloodline Power", Level = 16 },
                new ClassAbility { Name = "Bloodline Power", Level = 20 },
                new ClassAbility { Name = "Bloodrage", Level = 1 },
                new ClassAbility { Name = "Fast Movement", Level = 1 },
                new ClassAbility { Name = "Uncanny Dodge", Level = 2 },
                new ClassAbility { Name = "Blood Sanctuary", Level = 3 },
                new ClassAbility { Name = "Blood Casting", Level = 4 },
                new ClassAbility { Name = "Eschew Materials", Level = 4 },
                new ClassAbility { Name = "Spells", Level = 4 },
                new ClassAbility { Name = "Improved Uncanny Dodge", Level = 5 },
                new ClassAbility { Name = "Bloodline Feat", Level = 6 },
                new ClassAbility { Name = "Bloodline Feat", Level = 9 },
                new ClassAbility { Name = "Bloodline Feat", Level = 12 },
                new ClassAbility { Name = "Bloodline Feat", Level = 15 },
                new ClassAbility { Name = "Bloodline Feat", Level = 18 },
                new ClassAbility { Name = "Damage Reduction 1/-", Level = 7 },
                new ClassAbility { Name = "Damage Reduction 2/-", Level = 10 },
                new ClassAbility { Name = "Damage Reduction 3/-", Level = 13 },
                new ClassAbility { Name = "Damage Reduction 4/-", Level = 16 },
                new ClassAbility { Name = "Damage Reduction 5/-", Level = 19 },
                new ClassAbility { Name = "Greater Bloodrage", Level = 11 },
                new ClassAbility { Name = "Indomitable Will", Level = 14 },
                new ClassAbility { Name = "Tireless Bloodrage", Level = 17 },
                new ClassAbility { Name = "Mighty Bloodrage", Level = 20 },
            };
        }
    }
}
