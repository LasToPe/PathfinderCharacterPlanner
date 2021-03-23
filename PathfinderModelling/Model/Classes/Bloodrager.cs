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
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null),
                    new CasterLevel( 2, null),
                    new CasterLevel( 3, null),
                    new CasterLevel( 4, null, 1),
                    new CasterLevel( 5, null, 1),
                    new CasterLevel( 6, null, 1),
                    new CasterLevel( 7, null, 1, 1),
                    new CasterLevel( 8, null, 1, 1),
                    new CasterLevel( 9, null, 2, 1),
                    new CasterLevel(10, null, 2, 1, 1),
                    new CasterLevel(11, null, 2, 1, 1),
                    new CasterLevel(12, null, 2, 2, 1),
                    new CasterLevel(13, null, 3, 2, 1, 1),
                    new CasterLevel(14, null, 3, 2, 1, 1),
                    new CasterLevel(15, null, 3, 2, 2, 1),
                    new CasterLevel(16, null, 3, 3, 2, 1),
                    new CasterLevel(17, null, 4, 3, 2, 1),
                    new CasterLevel(18, null, 4, 3, 2, 2),
                    new CasterLevel(19, null, 4, 3, 3, 2),
                    new CasterLevel(20, null, 4, 4, 3, 2),
                }
            };
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
