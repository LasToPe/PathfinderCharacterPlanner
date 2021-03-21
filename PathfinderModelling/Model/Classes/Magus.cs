using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Magus : CharacterClass
    {
        public Magus()
        {
            Name = "Magus";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Arcane Pool", Level = 1 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spell Combat", Level = 1 },
                new ClassAbility { Name = "Spellstrike", Level = 2 },
                new ClassAbility { Name = "Magus Arcana", Level = 3 },
                new ClassAbility { Name = "Magus Arcana", Level = 6 },
                new ClassAbility { Name = "Magus Arcana", Level = 9 },
                new ClassAbility { Name = "Magus Arcana", Level = 12 },
                new ClassAbility { Name = "Magus Arcana", Level = 15 },
                new ClassAbility { Name = "Magus Arcana", Level = 18 },
                new ClassAbility { Name = "Spell Recall", Level = 4 },
                new ClassAbility { Name = "Bonus Feat", Level = 5 },
                new ClassAbility { Name = "Bonus Feat", Level = 11 },
                new ClassAbility { Name = "Bonus Feat", Level = 17 },
                new ClassAbility { Name = "Knowledge Pool", Level = 7 },
                new ClassAbility { Name = "Medium Armor", Level = 7 },
                new ClassAbility { Name = "Improved Spell Combat", Level = 8 },
                new ClassAbility { Name = "Fighter Training", Level = 10 },
                new ClassAbility { Name = "Improved Spell Recall", Level = 11 },
                new ClassAbility { Name = "Heavy Armor", Level = 13 },
                new ClassAbility { Name = "Greater Spell Combat", Level = 14 },
                new ClassAbility { Name = "Counterstrike", Level = 16 },
                new ClassAbility { Name = "Greater Spell Access", Level = 19 },
                new ClassAbility { Name = "True Magus", Level = 20 },
            };
        }
    }
}
