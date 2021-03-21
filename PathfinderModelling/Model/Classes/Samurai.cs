using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Samurai : CharacterClass
    {
        public Samurai()
        {
            Name = "Samurai";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Challenge 1/day", Level = 1 },
                new ClassAbility { Name = "Challenge 2/day", Level = 4 },
                new ClassAbility { Name = "Challenge 3/day", Level = 7 },
                new ClassAbility { Name = "Challenge 4/day", Level = 10 },
                new ClassAbility { Name = "Challenge 5/day", Level = 13 },
                new ClassAbility { Name = "Challenge 6/day", Level = 16 },
                new ClassAbility { Name = "Challenge 7/day", Level = 19 },
                new ClassAbility { Name = "Mount", Level = 1 },
                new ClassAbility { Name = "Order", Level = 1 },
                new ClassAbility { Name = "Resolve", Level = 1 },
                new ClassAbility { Name = "Order Ability", Level = 2 },
                new ClassAbility { Name = "Order Ability", Level = 8 },
                new ClassAbility { Name = "Order Ability", Level = 15 },
                new ClassAbility { Name = "Weapon Expertise", Level = 3 },
                new ClassAbility { Name = "Mounted Archer", Level = 4 },
                new ClassAbility { Name = "Banner", Level = 5 },
                new ClassAbility { Name = "Bonus Feat", Level = 6 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 18 },
                new ClassAbility { Name = "Greater Resolve", Level = 9 },
                new ClassAbility { Name = "Honorable Stand", Level = 11 },
                new ClassAbility { Name = "Demanding Challenge", Level = 12 },
                new ClassAbility { Name = "Greater Banner", Level = 14 },
                new ClassAbility { Name = "True Resolve", Level = 17 },
                new ClassAbility { Name = "Last Stand", Level = 20 },
            };
        }
    }
}
