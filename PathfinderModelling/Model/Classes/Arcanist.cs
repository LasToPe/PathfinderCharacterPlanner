using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Arcanist : CharacterClass
    {
        public Arcanist()
        {
            Name = "Arcanist";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Arcane Resevoir", Level = 1 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 1 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 3 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 5 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 7 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 9 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 11 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 13 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 15 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 17 },
                new ClassAbility { Name = "Arcanist Exploit", Level = 19 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Consume Spells", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Greater Exploits", Level = 11 },
                new ClassAbility { Name = "Magical Supremacy", Level = 20 },
            };
        }
    }
}
