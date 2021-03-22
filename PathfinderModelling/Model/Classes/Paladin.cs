using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Paladin : CharacterClass
    {
        public Paladin()
        {
            Name = "Paladin";
            Alignment = "Lawful Good";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Aura of Good", Level = 1 },
                new ClassAbility { Name = "Detect Evil", Level = 1 },
                new ClassAbility { Name = "Smite Evil 1/day", Level = 1 },
                new ClassAbility { Name = "Smite Evil 2/day", Level = 4 },
                new ClassAbility { Name = "Smite Evil 3/day", Level = 7 },
                new ClassAbility { Name = "Smite Evil 4/day", Level = 10 },
                new ClassAbility { Name = "Smite Evil 5/day", Level = 13 },
                new ClassAbility { Name = "Smite Evil 6/day", Level = 16 },
                new ClassAbility { Name = "Smite Evil 7/day", Level = 19 },
                new ClassAbility { Name = "Lay on Hands", Level = 2 },
                new ClassAbility { Name = "Divine Grace", Level = 2 },
                new ClassAbility { Name = "Aura of Courage", Level = 3 },
                new ClassAbility { Name = "Divine Health", Level = 3 },
                new ClassAbility { Name = "Mercy", Level = 3 },
                new ClassAbility { Name = "Mercy", Level = 6 },
                new ClassAbility { Name = "Mercy", Level = 9 },
                new ClassAbility { Name = "Mercy", Level = 12 },
                new ClassAbility { Name = "Mercy", Level = 15 },
                new ClassAbility { Name = "Mercy", Level = 18 },
                new ClassAbility { Name = "Channel Positive Energy", Level = 4 },
                new ClassAbility { Name = "Spells", Level = 4 },
                new ClassAbility { Name = "Divine Bond", Level = 5 },
                new ClassAbility { Name = "Aura of Resolve", Level = 8 },
                new ClassAbility { Name = "Aura of Justice", Level = 11 },
                new ClassAbility { Name = "Aura of Faith", Level = 14 },
                new ClassAbility { Name = "Aura of Righteousness", Level = 17 },
                new ClassAbility { Name = "Holy Champion", Level = 20 },
            };
        }
    }
}
