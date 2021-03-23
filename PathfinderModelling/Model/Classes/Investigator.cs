using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Investigator : CharacterClass
    {
        public Investigator()
        {
            Name = "Investigator";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting()
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 1),
                    new CasterLevel( 2, null, 2),
                    new CasterLevel( 3, null, 3),
                    new CasterLevel( 4, null, 3, 1),
                    new CasterLevel( 5, null, 4, 2),
                    new CasterLevel( 6, null, 4, 3),
                    new CasterLevel( 7, null, 4, 3, 1),
                    new CasterLevel( 8, null, 4, 4, 2),
                    new CasterLevel( 9, null, 5, 4, 3),
                    new CasterLevel(10, null, 5, 4, 3, 1),
                    new CasterLevel(11, null, 5, 4, 4, 2),
                    new CasterLevel(12, null, 5, 5, 4, 3),
                    new CasterLevel(13, null, 5, 5, 4, 3, 1),
                    new CasterLevel(14, null, 5, 5, 4, 4, 2),
                    new CasterLevel(15, null, 5, 5, 5, 4, 3),
                    new CasterLevel(16, null, 5, 5, 5, 4, 3, 1),
                    new CasterLevel(17, null, 5, 5, 5, 4, 4, 2),
                    new CasterLevel(18, null, 5, 5, 5, 5, 4, 3),
                    new CasterLevel(19, null, 5, 5, 5, 5, 5, 4),
                    new CasterLevel(20, null, 5, 5, 5, 5, 5, 5),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Alchemy", Level = 1 },
                new ClassAbility { Name = "Inspiration", Level = 1 },
                new ClassAbility { Name = "Trapfinding", Level = 1 },
                new ClassAbility { Name = "Poison Lore", Level = 2 },
                new ClassAbility { Name = "Poison Resistance +2", Level = 2 },
                new ClassAbility { Name = "Poison Resistance +4", Level = 5 },
                new ClassAbility { Name = "Poison Resistance +6", Level = 8 },
                new ClassAbility { Name = "Poison Immunity", Level = 11 },
                new ClassAbility { Name = "Investigator Talent", Level = 3 },
                new ClassAbility { Name = "Investigator Talent", Level = 5 },
                new ClassAbility { Name = "Investigator Talent", Level = 7 },
                new ClassAbility { Name = "Investigator Talent", Level = 9 },
                new ClassAbility { Name = "Investigator Talent", Level = 11 },
                new ClassAbility { Name = "Investigator Talent", Level = 13 },
                new ClassAbility { Name = "Investigator Talent", Level = 15 },
                new ClassAbility { Name = "Investigator Talent", Level = 17 },
                new ClassAbility { Name = "Investigator Talent", Level = 19 },
                new ClassAbility { Name = "Keen Recollection", Level = 3 },
                new ClassAbility { Name = "Trap Sense +1", Level = 3 },
                new ClassAbility { Name = "Trap Sense +2", Level = 6 },
                new ClassAbility { Name = "Trap Sense +3", Level = 9 },
                new ClassAbility { Name = "Trap Sense +4", Level = 12 },
                new ClassAbility { Name = "Trap Sense +5", Level = 15 },
                new ClassAbility { Name = "Trap Sense +6", Level = 18 },
                new ClassAbility { Name = "Studied Combat", Level = 4 },
                new ClassAbility { Name = "Studied Strike +1d6", Level = 4 },
                new ClassAbility { Name = "Studied Strike +2d6", Level = 6 },
                new ClassAbility { Name = "Studied Strike +3d6", Level = 8 },
                new ClassAbility { Name = "Studied Strike +4d6", Level = 10 },
                new ClassAbility { Name = "Studied Strike +5d6", Level = 12 },
                new ClassAbility { Name = "Studied Strike +6d6", Level = 14 },
                new ClassAbility { Name = "Studied Strike +7d6", Level = 16 },
                new ClassAbility { Name = "Studied Strike +8d6", Level = 18 },
                new ClassAbility { Name = "Studied Strike +9d6", Level = 20 },
                new ClassAbility { Name = "Swift Alchemy", Level = 4 },
                new ClassAbility { Name = "True Inspiration", Level = 20 },
            };
        }
    }
}
