using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Inquisitor : CharacterClass
    {
        public Inquisitor()
        {
            Name = "Inquisitor";
            Alignment = "Within one step of her deity";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Domain", Level = 1 },
                new ClassAbility { Name = "Judgement 1/day", Level = 1 },
                new ClassAbility { Name = "Judgement 2/day", Level = 4 },
                new ClassAbility { Name = "Judgement 3/day", Level = 7 },
                new ClassAbility { Name = "Judgement 4/day", Level = 10 },
                new ClassAbility { Name = "Judgement 5/day", Level = 13 },
                new ClassAbility { Name = "Judgement 6/day", Level = 16 },
                new ClassAbility { Name = "Judgement 7/day", Level = 19 },
                new ClassAbility { Name = "Monster Lore", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Stern Gaze", Level = 1 },
                new ClassAbility { Name = "Cunning Initiative", Level = 2 },
                new ClassAbility { Name = "Detect Alignment", Level = 2 },
                new ClassAbility { Name = "Track", Level = 2 },
                new ClassAbility { Name = "Solo Tactics", Level = 3 },
                new ClassAbility { Name = "Teamwork Feat", Level = 3 },
                new ClassAbility { Name = "Teamwork Feat", Level = 6 },
                new ClassAbility { Name = "Teamwork Feat", Level = 9 },
                new ClassAbility { Name = "Teamwork Feat", Level = 12 },
                new ClassAbility { Name = "Teamwork Feat", Level = 15 },
                new ClassAbility { Name = "Teamwork Feat", Level = 18 },
                new ClassAbility { Name = "Bane", Level = 5 },
                new ClassAbility { Name = "Discern Lies", Level = 5 },
                new ClassAbility { Name = "Second Judgement", Level = 8 },
                new ClassAbility { Name = "Stalwart", Level = 11 },
                new ClassAbility { Name = "Greater Bane", Level = 12 },
                new ClassAbility { Name = "Exploit Weakness", Level = 14 },
                new ClassAbility { Name = "Third Judgement", Level = 16 },
                new ClassAbility { Name = "Slayer", Level = 17 },
                new ClassAbility { Name = "True Judgement", Level = 20 },
            };
        }
    }
}
