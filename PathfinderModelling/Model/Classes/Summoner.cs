using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    class Summoner : CharacterClass
    {
        public Summoner()
        {
            Name = "Summoner";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Eidolon", Level = 1 },
                new ClassAbility { Name = "Life Link", Level = 1 },
                new ClassAbility { Name = "Summon Monster I", Level = 1 },
                new ClassAbility { Name = "Summon Monster II", Level = 3 },
                new ClassAbility { Name = "Summon Monster III", Level = 5 },
                new ClassAbility { Name = "Summon Monster IV", Level = 7 },
                new ClassAbility { Name = "Summon Monster V", Level = 9 },
                new ClassAbility { Name = "Summon Monster VI", Level = 11 },
                new ClassAbility { Name = "Summon Monster VII", Level = 13 },
                new ClassAbility { Name = "Summon Monster VIII", Level = 15 },
                new ClassAbility { Name = "Summon Monster IX", Level = 17 },
                new ClassAbility { Name = "Gate", Level = 19 },
                new ClassAbility { Name = "Bonded Senses", Level = 2 },
                new ClassAbility { Name = "Shield Ally", Level = 4 },
                new ClassAbility { Name = "Master's Call", Level = 6 },
                new ClassAbility { Name = "Transposition", Level = 8 },
                new ClassAbility { Name = "Aspect", Level = 10 },
                new ClassAbility { Name = "Greater Shield Ally", Level = 12 },
                new ClassAbility { Name = "Life Bond", Level = 14 },
                new ClassAbility { Name = "Merge Forms", Level = 16 },
                new ClassAbility { Name = "Greater Aspect", Level = 18 },
                new ClassAbility { Name = "Twin Eidolon", Level = 20 },
            };
        }
    }
}
