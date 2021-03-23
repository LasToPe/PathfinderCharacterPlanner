using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Summoner : CharacterClass
    {
        public Summoner()
        {
            Name = "Summoner";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting()
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 1),
                    new CasterLevel( 2, null, 2),
                    new CasterLevel( 3, null, 3),
                    new CasterLevel( 4, null, 3, 1),
                    new CasterLevel( 5, null, 4, 2),
                    new CasterLevel( 6, null, 4, 3),
                    new CasterLevel( 7, null, 4, 3, 1),
                    new CasterLevel( 8, null, 4, 4, 2),
                    new CasterLevel( 9, null, 5, 4, 3),
                    new CasterLevel(10, null, 5, 4, 3, 1),
                    new CasterLevel(11, null, 5, 4, 4, 2),
                    new CasterLevel(12, null, 5, 5, 4, 3),
                    new CasterLevel(13, null, 5, 5, 4, 3, 1),
                    new CasterLevel(14, null, 5, 5, 4, 4, 2),
                    new CasterLevel(15, null, 5, 5, 5, 4, 3),
                    new CasterLevel(16, null, 5, 5, 5, 4, 3, 1),
                    new CasterLevel(17, null, 5, 5, 5, 4, 4, 2),
                    new CasterLevel(18, null, 5, 5, 5, 5, 4, 3),
                    new CasterLevel(19, null, 5, 5, 5, 5, 5, 4),
                    new CasterLevel(20, null, 5, 5, 5, 5, 5, 5),
                }
            };
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
