using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Gunslinger : CharacterClass
    {
        public Gunslinger()
        {
            Name = "Gunslinger";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Deeds", Level = 1 },
                new ClassAbility { Name = "Deeds", Level = 3 },
                new ClassAbility { Name = "Deeds", Level = 7 },
                new ClassAbility { Name = "Deeds", Level = 11 },
                new ClassAbility { Name = "Deeds", Level = 15 },
                new ClassAbility { Name = "Deeds", Level = 19 },
                new ClassAbility { Name = "Grit", Level = 1 },
                new ClassAbility { Name = "Gunsmith", Level = 1 },
                new ClassAbility { Name = "Nimble +1", Level = 2 },
                new ClassAbility { Name = "Nimble +2", Level = 6 },
                new ClassAbility { Name = "Nimble +3", Level = 10 },
                new ClassAbility { Name = "Nimble +4", Level = 14 },
                new ClassAbility { Name = "Nimble +5", Level = 18 },
                new ClassAbility { Name = "Bonus Feat", Level = 4 },
                new ClassAbility { Name = "Bonus Feat", Level = 8 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 16 },
                new ClassAbility { Name = "Bonus Feat", Level = 20 },
                new ClassAbility { Name = "Gun Training 1", Level = 5 },
                new ClassAbility { Name = "Gun Training 2", Level = 9 },
                new ClassAbility { Name = "Gun Training 3", Level = 13 },
                new ClassAbility { Name = "Gun Training 4", Level = 17 },
                new ClassAbility { Name = "True Grit", Level = 20 },
            };
        }
    }
}
