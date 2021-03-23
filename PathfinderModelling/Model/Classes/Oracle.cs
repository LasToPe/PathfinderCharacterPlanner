using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Oracle : CharacterClass
    {
        public Oracle()
        {
            Name = "Oracle";
            BaseAttackBonus = BaseAttackBonus.Medium;
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
                new ClassAbility { Name = "Mystery", Level = 1 },
                new ClassAbility { Name = "Oracle's Curse", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Revelation", Level = 1 },
                new ClassAbility { Name = "Revelation", Level = 3 },
                new ClassAbility { Name = "Revelation", Level = 7 },
                new ClassAbility { Name = "Revelation", Level = 11 },
                new ClassAbility { Name = "Revelation", Level = 15 },
                new ClassAbility { Name = "Revelation", Level = 19 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Mystery Spell", Level = 2 },
                new ClassAbility { Name = "Mystery Spell", Level = 4 },
                new ClassAbility { Name = "Mystery Spell", Level = 6 },
                new ClassAbility { Name = "Mystery Spell", Level = 8 },
                new ClassAbility { Name = "Mystery Spell", Level = 10 },
                new ClassAbility { Name = "Mystery Spell", Level = 12 },
                new ClassAbility { Name = "Mystery Spell", Level = 14 },
                new ClassAbility { Name = "Mystery Spell", Level = 16 },
                new ClassAbility { Name = "Mystery Spell", Level = 18 },
                new ClassAbility { Name = "Final Revelation", Level = 20 },
            };
        }
    }
}
