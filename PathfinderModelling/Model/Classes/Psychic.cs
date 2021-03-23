using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Psychic : CharacterClass
    {
        public Psychic()
        {
            Name = "Psychic";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 3),
                    new CasterLevel( 2, null, 4),
                    new CasterLevel( 3, null, 5),
                    new CasterLevel( 4, null, 6, 3),
                    new CasterLevel( 5, null, 6, 4),
                    new CasterLevel( 6, null, 6, 5, 3),
                    new CasterLevel( 7, null, 6, 6, 4),
                    new CasterLevel( 8, null, 6, 6, 5, 3),
                    new CasterLevel( 9, null, 6, 6, 6, 4),
                    new CasterLevel(10, null, 6, 6, 6, 5, 3),
                    new CasterLevel(11, null, 6, 6, 6, 6, 4),
                    new CasterLevel(12, null, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(13, null, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(14, null, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(15, null, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(16, null, 6, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(17, null, 6, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(18, null, 6, 6, 6, 6, 6, 6, 6, 5, 3),
                    new CasterLevel(19, null, 6, 6, 6, 6, 6, 6, 6, 6, 4),
                    new CasterLevel(20, null, 6, 6, 6, 6, 6, 6, 6, 6, 6),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Discipline Power", Level = 1 },
                new ClassAbility { Name = "Discipline Power", Level = 5 },
                new ClassAbility { Name = "Discipline Power", Level = 13 },
                new ClassAbility { Name = "Discipline Spell", Level = 1 },
                new ClassAbility { Name = "Discipline Spell", Level = 4 },
                new ClassAbility { Name = "Discipline Spell", Level = 6 },
                new ClassAbility { Name = "Discipline Spell", Level = 8 },
                new ClassAbility { Name = "Discipline Spell", Level = 10 },
                new ClassAbility { Name = "Discipline Spell", Level = 12 },
                new ClassAbility { Name = "Discipline Spell", Level = 14 },
                new ClassAbility { Name = "Discipline Spell", Level = 16 },
                new ClassAbility { Name = "Discipline Spell", Level = 18 },
                new ClassAbility { Name = "Knacks", Level = 1 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 1 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 3 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 7 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 11 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 15 },
                new ClassAbility { Name = "Phrenic Amplification", Level = 19 },
                new ClassAbility { Name = "Phrenic Pool", Level = 1 },
                new ClassAbility { Name = "Psychic Discipline", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Detect Thoughts", Level = 2 },
                new ClassAbility { Name = "Telepathic Bond", Level = 9 },
                new ClassAbility { Name = "Major Amplifications", Level = 11 },
                new ClassAbility { Name = "Telepathy", Level = 17 },
                new ClassAbility { Name = "Remade Self", Level = 20 },
            };
        }
    }
}
