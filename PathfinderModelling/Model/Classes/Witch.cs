using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Witch : CharacterClass
    {
        public Witch()
        {
            Name = "Witch";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, 3, 1),
                    new CasterLevel( 2, 4, 2),
                    new CasterLevel( 3, 4, 2, 1),
                    new CasterLevel( 4, 4, 3, 2),
                    new CasterLevel( 5, 4, 3, 2, 1),
                    new CasterLevel( 6, 4, 3, 3, 2),
                    new CasterLevel( 7, 4, 4, 3, 2, 1),
                    new CasterLevel( 8, 4, 4, 3, 3, 2),
                    new CasterLevel( 9, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(10, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(11, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(12, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(13, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(14, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(15, 4, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(16, 4, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(17, 4, 4, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(18, 4, 4, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(19, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3),
                    new CasterLevel(20, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Hex", Level = 1 },
                new ClassAbility { Name = "Hex", Level = 2 },
                new ClassAbility { Name = "Hex", Level = 4 },
                new ClassAbility { Name = "Hex", Level = 6 },
                new ClassAbility { Name = "Hex", Level = 8 },
                new ClassAbility { Name = "Hex", Level = 10 },
                new ClassAbility { Name = "Hex", Level = 12 },
                new ClassAbility { Name = "Hex", Level = 14 },
                new ClassAbility { Name = "Hex", Level = 16 },
                new ClassAbility { Name = "Hex", Level = 18 },
                new ClassAbility { Name = "Hex", Level = 20 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Witch's Familiar", Level = 1 },
                new ClassAbility { Name = "Major Hex", Level = 10 },
                new ClassAbility { Name = "Grand Hex", Level = 18 },
            };
        }
    }
}
