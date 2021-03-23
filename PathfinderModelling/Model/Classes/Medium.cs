using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Medium : CharacterClass
    {
        public Medium()
        {
            Name = "Medium";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
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
                    new CasterLevel( 4, null, 1),
                    new CasterLevel( 5, null, 1),
                    new CasterLevel( 6, null, 1),
                    new CasterLevel( 7, null, 1, 1),
                    new CasterLevel( 8, null, 1, 1),
                    new CasterLevel( 9, null, 2, 1),
                    new CasterLevel(10, null, 2, 1, 1),
                    new CasterLevel(11, null, 2, 1, 1),
                    new CasterLevel(12, null, 2, 2, 1),
                    new CasterLevel(13, null, 3, 2, 1, 1),
                    new CasterLevel(14, null, 3, 2, 1, 1),
                    new CasterLevel(15, null, 3, 2, 2, 1),
                    new CasterLevel(16, null, 3, 3, 2, 1),
                    new CasterLevel(17, null, 4, 3, 2, 1),
                    new CasterLevel(18, null, 4, 3, 2, 2),
                    new CasterLevel(19, null, 4, 3, 3, 2),
                    new CasterLevel(20, null, 4, 4, 3, 2),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Knacks", Level = 1 },
                new ClassAbility { Name = "Spirit", Level = 1 },
                new ClassAbility { Name = "Spirit Bonus +1", Level = 1 },
                new ClassAbility { Name = "Spirit Bonus +2", Level = 4 },
                new ClassAbility { Name = "Spirit Bonus +3", Level = 8 },
                new ClassAbility { Name = "Spirit Bonus +4", Level = 12 },
                new ClassAbility { Name = "Spirit Bonus +5", Level = 16 },
                new ClassAbility { Name = "Spirit Bonus +6", Level = 20 },
                new ClassAbility { Name = "Spirit Power (lesser)", Level = 1 },
                new ClassAbility { Name = "Spirit Power (intermediate)", Level = 6 },
                new ClassAbility { Name = "Spirit Power (greater)", Level = 11 },
                new ClassAbility { Name = "Spirit Power (supreme)", Level = 17 },
                new ClassAbility { Name = "Spirit Surge 1d6", Level = 1 },
                new ClassAbility { Name = "Spirit Surge 1d8", Level = 10 },
                new ClassAbility { Name = "Spirit Surge 1d10", Level = 20 },
                new ClassAbility { Name = "Shared Seance", Level = 2 },
                new ClassAbility { Name = "Taboo", Level = 2 },
                new ClassAbility { Name = "Haunt Channeler", Level = 3 },
                new ClassAbility { Name = "Location Channel", Level = 5 },
                new ClassAbility { Name = "Connection Channel", Level = 7 },
                new ClassAbility { Name = "Propitiation", Level = 9 },
                new ClassAbility { Name = "Ask the Spirits", Level = 13 },
                new ClassAbility { Name = "Astral Journey", Level = 14 },
                new ClassAbility { Name = "Trance of Three", Level = 15 },
                new ClassAbility { Name = "Spacious Soul", Level = 18 },
                new ClassAbility { Name = "Spirit Mastery", Level = 19 },
                new ClassAbility { Name = "Astral Beacon", Level = 20 },
            };
        }
    }
}
