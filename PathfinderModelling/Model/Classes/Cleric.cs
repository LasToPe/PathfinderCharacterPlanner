using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Cleric : CharacterClass
    {
        public Cleric()
        {
            Name = "Cleric";
            Alignment = "Within one step of her deity";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
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
                new ClassAbility { Name = "Aura", Level = 1 },
                new ClassAbility { Name = "Channel Energy 1d6", Level = 1 },
                new ClassAbility { Name = "Channel Energy 2d6", Level = 3 },
                new ClassAbility { Name = "Channel Energy 3d6", Level = 5 },
                new ClassAbility { Name = "Channel Energy 4d6", Level = 7 },
                new ClassAbility { Name = "Channel Energy 5d6", Level = 9 },
                new ClassAbility { Name = "Channel Energy 6d6", Level = 11 },
                new ClassAbility { Name = "Channel Energy 7d6", Level = 13 },
                new ClassAbility { Name = "Channel Energy 8d6", Level = 15 },
                new ClassAbility { Name = "Channel Energy 9d6", Level = 17 },
                new ClassAbility { Name = "Channel Energy 10d6", Level = 19 },
                new ClassAbility { Name = "Domains", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spontaneous Casting", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
            };
        }
    }
}
