using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Skald : CharacterClass
    {
        public Skald()
        {
            Name = "Skald";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bardic Knowledge", Level = 1 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Inspired Rage +1", Level = 1 },
                new ClassAbility { Name = "Inspired Rage +2", Level = 4 },
                new ClassAbility { Name = "Inspired Rage +3", Level = 8 },
                new ClassAbility { Name = "Inspired Rage +4", Level = 12 },
                new ClassAbility { Name = "Inspired Rage +5", Level = 16 },
                new ClassAbility { Name = "Raging Song", Level = 1 },
                new ClassAbility { Name = "Scribe Scroll", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Veratile Performance", Level = 2 },
                new ClassAbility { Name = "Veratile Performance", Level = 7 },
                new ClassAbility { Name = "Veratile Performance", Level = 12 },
                new ClassAbility { Name = "Veratile Performance", Level = 17 },
                new ClassAbility { Name = "Well-Versed", Level = 2 },
                new ClassAbility { Name = "Rage Power", Level = 3 },
                new ClassAbility { Name = "Rage Power", Level = 6 },
                new ClassAbility { Name = "Rage Power", Level = 9 },
                new ClassAbility { Name = "Rage Power", Level = 12 },
                new ClassAbility { Name = "Rage Power", Level = 15 },
                new ClassAbility { Name = "Rage Power", Level = 18 },
                new ClassAbility { Name = "Marching Song", Level = 3 },
                new ClassAbility { Name = "Uncanny Dodge", Level = 4 },
                new ClassAbility { Name = "Spell Kenning 1/day", Level = 5 },
                new ClassAbility { Name = "Spell Kenning 2/day", Level = 11 },
                new ClassAbility { Name = "Spell Kenning 3/day", Level = 17 },
                new ClassAbility { Name = "Song of Strength", Level = 6 },
                new ClassAbility { Name = "Lore Master 1/day", Level = 7 },
                new ClassAbility { Name = "Lore Master 2/day", Level = 13 },
                new ClassAbility { Name = "Lore Master 3/day", Level = 19 },
                new ClassAbility { Name = "Improved Uncanny Dodge", Level = 8 },
                new ClassAbility { Name = "Damage Reduction 1/-", Level = 9 },
                new ClassAbility { Name = "Damage Reduction 2/-", Level = 14 },
                new ClassAbility { Name = "Damage Reduction 3/-", Level = 19 },
                new ClassAbility { Name = "Dirge of Doom", Level = 10 },
                new ClassAbility { Name = "Song of the Fallen", Level = 10 },
                new ClassAbility { Name = "Master Skald", Level = 20 },
            };
        }
    }
}
