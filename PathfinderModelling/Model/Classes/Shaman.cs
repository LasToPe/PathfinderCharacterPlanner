using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Shaman : CharacterClass
    {
        public Shaman()
        {
            Name = "Shaman";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spirit Animal", Level = 1 },
                new ClassAbility { Name = "Spirit Magic", Level = 1 },
                new ClassAbility { Name = "Hex", Level = 2 },
                new ClassAbility { Name = "Hex", Level = 4 },
                new ClassAbility { Name = "Hex", Level = 8 },
                new ClassAbility { Name = "Hex", Level = 10 },
                new ClassAbility { Name = "Hex", Level = 12 },
                new ClassAbility { Name = "Hex", Level = 16 },
                new ClassAbility { Name = "Hex", Level = 18 },
                new ClassAbility { Name = "Hex", Level = 20 },
                new ClassAbility { Name = "Wandering Spirit", Level = 4 },
                new ClassAbility { Name = "Wandering Spirit (greater)", Level = 12 },
                new ClassAbility { Name = "Wandering Spirit (true)", Level = 20 },
                new ClassAbility { Name = "Wandering Hex", Level = 6 },
                new ClassAbility { Name = "Wandering Hex (2 hexes)", Level = 14 },
                new ClassAbility { Name = "Spirit (greater)", Level = 8 },
                new ClassAbility { Name = "Spirit (true)", Level = 16 },
                new ClassAbility { Name = "Manifestation", Level = 20 },
            };
        }
    }
}
