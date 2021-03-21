using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Shifter : CharacterClass
    {
        public Shifter()
        {
            Name = "Shifter";
            Alignment = "Any neutral";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Shifter Aspect", Level = 1 },
                new ClassAbility { Name = "Second Aspect", Level = 5 },
                new ClassAbility { Name = "Third Aspect", Level = 10 },
                new ClassAbility { Name = "Fourth Aspect", Level = 15 },
                new ClassAbility { Name = "Shifter Claws 1d4", Level = 1 },
                new ClassAbility { Name = "Shifter Claws (cold iron, magic, silver)", Level = 3 },
                new ClassAbility { Name = "Shifter Claws 1d6", Level = 7 },
                new ClassAbility { Name = "Shifter Claws 1d8", Level = 11 },
                new ClassAbility { Name = "Shifter Claws 1d10", Level = 13 },
                new ClassAbility { Name = "Shifter Claws (x3)", Level = 17 },
                new ClassAbility { Name = "Shifter Claws (adamantine)", Level = 19 },
                new ClassAbility { Name = "Wild Empathy", Level = 1 },
                new ClassAbility { Name = "Defensive Instinct (wis)", Level = 2 },
                new ClassAbility { Name = "Defensive Instinct +1", Level = 4 },
                new ClassAbility { Name = "Defensive Instinct +2", Level = 8 },
                new ClassAbility { Name = "Defensive Instinct +3", Level = 12 },
                new ClassAbility { Name = "Defensive Instinct +4", Level = 16 },
                new ClassAbility { Name = "Defensive Instinct +5", Level = 20 },
                new ClassAbility { Name = "Track", Level = 2 },
                new ClassAbility { Name = "Woodland Stride", Level = 3 },
                new ClassAbility { Name = "Wild Shape", Level = 4 },
                new ClassAbility { Name = "Trackless Step", Level = 5 },
                new ClassAbility { Name = "Shifter's Fury", Level = 6 },
                new ClassAbility { Name = "Chimeric Aspect", Level = 9 },
                new ClassAbility { Name = "Greater Chimeric Aspect", Level = 14 },
                new ClassAbility { Name = "A Thousand Faces", Level = 18 },
                new ClassAbility { Name = "Timeless Body", Level = 18 },
                new ClassAbility { Name = "Final Aspect", Level = 9 },
            };
        }
    }
}
