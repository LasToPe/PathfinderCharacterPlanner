using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Antipaladin : CharacterClass
    {
        public Antipaladin()
        {
            Name = "Antipaladin";
            Alignment = "Chaotic Evil";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null),
                    new CasterLevel( 2, null),
                    new CasterLevel( 3, null),
                    new CasterLevel( 4, null, 0),
                    new CasterLevel( 5, null, 1),
                    new CasterLevel( 6, null, 1),
                    new CasterLevel( 7, null, 1, 0),
                    new CasterLevel( 8, null, 1, 1),
                    new CasterLevel( 9, null, 2, 1),
                    new CasterLevel(10, null, 2, 1, 0),
                    new CasterLevel(11, null, 2, 1, 1),
                    new CasterLevel(12, null, 2, 2, 1),
                    new CasterLevel(13, null, 3, 2, 1, 0),
                    new CasterLevel(14, null, 3, 2, 1, 1),
                    new CasterLevel(15, null, 3, 2, 2, 1),
                    new CasterLevel(16, null, 3, 3, 2, 1),
                    new CasterLevel(17, null, 4, 3, 2, 1),
                    new CasterLevel(18, null, 4, 3, 2, 2),
                    new CasterLevel(19, null, 4, 3, 3, 2),
                    new CasterLevel(20, null, 4, 4, 3, 3),
                }
            };

            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Aura of Evil", Level = 1 },
                new ClassAbility { Name = "Detect Good", Level = 1 },
                new ClassAbility { Name = "Smite Good 1/day", Level = 1 },
                new ClassAbility { Name = "Smite Good 2/day", Level = 4 },
                new ClassAbility { Name = "Smite Good 3/day", Level = 7 },
                new ClassAbility { Name = "Smite Good 4/day", Level = 10 },
                new ClassAbility { Name = "Smite Good 5/day", Level = 13 },
                new ClassAbility { Name = "Smite Good 6/day", Level = 16 },
                new ClassAbility { Name = "Smite Good 7/day", Level = 19 },
                new ClassAbility { Name = "Touch of Corruption", Level = 2 },
                new ClassAbility { Name = "Unholy Resilience", Level = 2 },
                new ClassAbility { Name = "Aura of Cowardice", Level = 3 },
                new ClassAbility { Name = "Cruelty", Level = 3 },
                new ClassAbility { Name = "Cruelty", Level = 6 },
                new ClassAbility { Name = "Cruelty", Level = 9 },
                new ClassAbility { Name = "Cruelty", Level = 12 },
                new ClassAbility { Name = "Cruelty", Level = 15 },
                new ClassAbility { Name = "Cruelty", Level = 18 },
                new ClassAbility { Name = "Channel Negative Energy", Level = 4 },
                new ClassAbility { Name = "Spells", Level = 4 },
                new ClassAbility { Name = "Fiendish Boon", Level = 5 },
                new ClassAbility { Name = "Aura of Despair", Level = 8 },
                new ClassAbility { Name = "Aura of Vengeance", Level = 11 },
                new ClassAbility { Name = "Aura of Sin", Level = 14 },
                new ClassAbility { Name = "Aura of Depravity", Level = 17 },
                new ClassAbility { Name = "Unholy Champion", Level = 20 },
            };
        }
    }
}
