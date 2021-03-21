using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    class Wizard : CharacterClass
    {
        public Wizard()
        {
            Name = "Wizard";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Arcane Bond", Level = 1 },
                new ClassAbility { Name = "Arcane School", Level = 1 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Scribe Scroll", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Bonus Feat", Level = 5 },
                new ClassAbility { Name = "Bonus Feat", Level = 10 },
                new ClassAbility { Name = "Bonus Feat", Level = 15 },
                new ClassAbility { Name = "Bonus Feat", Level = 20 },
            };
        }
    }
}
