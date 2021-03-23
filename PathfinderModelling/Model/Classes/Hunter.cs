using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Hunter : CharacterClass
    {
        public Hunter()
        {
            Name = "Hunter";
            Alignment = "Any neutral";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
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
                new ClassAbility { Name = "Animal Companion", Level = 1 },
                new ClassAbility { Name = "Animal Focus", Level = 1 },
                new ClassAbility { Name = "Nature Training", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Wild Empathy", Level = 1 },
                new ClassAbility { Name = "Precise Companion", Level = 2 },
                new ClassAbility { Name = "Track", Level = 2 },
                new ClassAbility { Name = "Hunter Tactics", Level = 3 },
                new ClassAbility { Name = "Teamwork Feat", Level = 3 },
                new ClassAbility { Name = "Teamwork Feat", Level = 6 },
                new ClassAbility { Name = "Teamwork Feat", Level = 9 },
                new ClassAbility { Name = "Teamwork Feat", Level = 12 },
                new ClassAbility { Name = "Teamwork Feat", Level = 15 },
                new ClassAbility { Name = "Teamwork Feat", Level = 18 },
                new ClassAbility { Name = "Improved Empathic Link", Level = 4 },
                new ClassAbility { Name = "Woodland Stride", Level = 5 },
                new ClassAbility { Name = "Bonus Trick", Level = 7 },
                new ClassAbility { Name = "Bonus Trick", Level = 13 },
                new ClassAbility { Name = "Bonus Trick", Level = 19 },
                new ClassAbility { Name = "Second Animal Focus", Level = 8 },
                new ClassAbility { Name = "Swift Tracker", Level = 8 },
                new ClassAbility { Name = "Raise Animal Companion", Level = 10 },
                new ClassAbility { Name = "Speak with Master", Level = 11 },
                new ClassAbility { Name = "Greater Emapthic Link", Level = 14 },
                new ClassAbility { Name = "One with the Wild", Level = 17 },
                new ClassAbility { Name = "Master Hunter", Level = 20 },
            };
        }
    }
}
