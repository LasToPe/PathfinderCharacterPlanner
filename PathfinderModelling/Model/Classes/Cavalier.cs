using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Cavalier : CharacterClass
    {
        public Cavalier()
        {
            Name = "Cavalier";
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
                new ClassAbility { Name = "Tactician", Level = 1 },
                new ClassAbility { Name = "Order Ability", Level = 2 },
                new ClassAbility { Name = "Order Ability", Level = 8 },
                new ClassAbility { Name = "Order Ability", Level = 15 },
                new ClassAbility { Name = "Cavalier's Charge", Level = 3 },
                new ClassAbility { Name = "Expert Trainer", Level = 4 },
                new ClassAbility { Name = "Banner", Level = 5 },
                new ClassAbility { Name = "Bonus Feat", Level = 6 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 18 },
                new ClassAbility { Name = "Greater Tactician", Level = 9 },
                new ClassAbility { Name = "Mighty Charge", Level = 11 },
                new ClassAbility { Name = "Demanding Challenge", Level = 12 },
                new ClassAbility { Name = "Greater Banner", Level = 14 },
                new ClassAbility { Name = "Master Tactician", Level = 17 },
                new ClassAbility { Name = "Supreme Charge", Level = 20 },
            };
        }
    }
}
