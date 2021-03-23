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
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 2),
                    new CasterLevel( 2, null, 3),
                    new CasterLevel( 3, null, 4),
                    new CasterLevel( 4, null, 4, 2),
                    new CasterLevel( 5, null, 4, 3),
                    new CasterLevel( 6, null, 4, 4, 2),
                    new CasterLevel( 7, null, 4, 4, 3),
                    new CasterLevel( 8, null, 4, 4, 4, 2),
                    new CasterLevel( 9, null, 4, 4, 4, 3),
                    new CasterLevel(10, null, 4, 4, 4, 4, 2),
                    new CasterLevel(11, null, 4, 4, 4, 4, 3),
                    new CasterLevel(12, null, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(13, null, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(14, null, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(15, null, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(16, null, 4, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(17, null, 4, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(18, null, 4, 4, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(19, null, 4, 4, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(20, null, 4, 4, 4, 4, 4, 4, 4, 4, 4),
                }
            };
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
