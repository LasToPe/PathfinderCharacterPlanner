using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Druid : CharacterClass
    {
        public Druid()
        {
            Name = "Druid";
            Alignment = "Any neutral";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Nature Bond", Level = 1 },
                new ClassAbility { Name = "Nature Sense", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spontaneous Casting", Level = 1 },
                new ClassAbility { Name = "Wild Empathy", Level = 1 },
                new ClassAbility { Name = "Woodland Stride", Level = 2 },
                new ClassAbility { Name = "Trackless Step", Level = 3 },
                new ClassAbility { Name = "Resist Nature's Lure", Level = 4 },
                new ClassAbility { Name = "Wild Shape 1/day", Level = 4 },
                new ClassAbility { Name = "Wild Shape 2/day", Level = 6 },
                new ClassAbility { Name = "Wild Shape 3/day", Level = 8 },
                new ClassAbility { Name = "Wild Shape 4/day", Level = 10 },
                new ClassAbility { Name = "Wild Shape 5/day", Level = 12 },
                new ClassAbility { Name = "Wild Shape 6/day", Level = 14 },
                new ClassAbility { Name = "Wild Shape 7/day", Level = 16 },
                new ClassAbility { Name = "Wild Shape 8/day", Level = 18 },
                new ClassAbility { Name = "Wild Shape at Will", Level = 20 },
                new ClassAbility { Name = "Venom Immunity", Level = 9 },
                new ClassAbility { Name = "A Thousand Faces", Level = 13 },
                new ClassAbility { Name = "Timeless Body", Level = 15 },
            };
        }
    }
}
