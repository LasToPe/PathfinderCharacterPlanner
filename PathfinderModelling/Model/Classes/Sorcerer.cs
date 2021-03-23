using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Sorcerer : CharacterClass
    {
        public Sorcerer()
        {
            Name = "Sorcerer";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 3),
                    new CasterLevel( 2, null, 4),
                    new CasterLevel( 3, null, 5),
                    new CasterLevel( 4, null, 6, 3),
                    new CasterLevel( 5, null, 6, 4),
                    new CasterLevel( 6, null, 6, 5, 3),
                    new CasterLevel( 7, null, 6, 6, 4),
                    new CasterLevel( 8, null, 6, 6, 5, 3),
                    new CasterLevel( 9, null, 6, 6, 6, 4),
                    new CasterLevel(10, null, 6, 6, 6, 5, 3),
                    new CasterLevel(11, null, 6, 6, 6, 6, 4),
                    new CasterLevel(12, null, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(13, null, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(14, null, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(15, null, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(16, null, 6, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(17, null, 6, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(18, null, 6, 6, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(19, null, 6, 6, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(20, null, 6, 6, 6, 6, 6, 6, 6, 6, 6),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bloodline", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 1 },
                new ClassAbility { Name = "Bloodline Power", Level = 3 },
                new ClassAbility { Name = "Bloodline Power", Level = 9 },
                new ClassAbility { Name = "Bloodline Power", Level = 15 },
                new ClassAbility { Name = "Bloodline Power", Level = 20 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Eschew Materials", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Bloodline Spell", Level = 3 },
                new ClassAbility { Name = "Bloodline Spell", Level = 5 },
                new ClassAbility { Name = "Bloodline Spell", Level = 7 },
                new ClassAbility { Name = "Bloodline Spell", Level = 9 },
                new ClassAbility { Name = "Bloodline Spell", Level = 11 },
                new ClassAbility { Name = "Bloodline Spell", Level = 13 },
                new ClassAbility { Name = "Bloodline Spell", Level = 15 },
                new ClassAbility { Name = "Bloodline Spell", Level = 17 },
                new ClassAbility { Name = "Bloodline Spell", Level = 19 },
                new ClassAbility { Name = "Bloodline Feat", Level = 7 },
                new ClassAbility { Name = "Bloodline Feat", Level = 13 },
                new ClassAbility { Name = "Bloodline Feat", Level = 19 },
            };
        }
    }
}
