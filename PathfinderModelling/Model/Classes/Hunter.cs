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
