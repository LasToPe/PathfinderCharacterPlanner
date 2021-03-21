using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    class Warpriest : CharacterClass
    {
        public Warpriest()
        {
            Name = "Warpriest";
            Alignment = "Within one step of her deity";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Aura", Level = 1 },
                new ClassAbility { Name = "Blessings (minor)", Level = 1 },
                new ClassAbility { Name = "Blessings (major)", Level = 10 },
                new ClassAbility { Name = "Focus Weapon", Level = 1 },
                new ClassAbility { Name = "Orisons", Level = 1 },
                new ClassAbility { Name = "Sacred Weapon (1d6)", Level = 1 },
                new ClassAbility { Name = "Sacred Weapon (1d8)", Level = 5 },
                new ClassAbility { Name = "Sacred Weapon (1d10)", Level = 10 },
                new ClassAbility { Name = "Sacred Weapon (2d6)", Level = 15 },
                new ClassAbility { Name = "Sacred Weapon (2d8)", Level = 20 },
                new ClassAbility { Name = "Sacred Weapon +1", Level = 4 },
                new ClassAbility { Name = "Sacred Weapon +2", Level = 8 },
                new ClassAbility { Name = "Sacred Weapon +3", Level = 12 },
                new ClassAbility { Name = "Sacred Weapon +4", Level = 16 },
                new ClassAbility { Name = "Sacred Weapon +5", Level = 20 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Spontaneous Casting", Level = 1 },
                new ClassAbility { Name = "Fervor 1d6", Level = 2 },
                new ClassAbility { Name = "Fervor 2d6", Level = 5 },
                new ClassAbility { Name = "Fervor 3d6", Level = 8 },
                new ClassAbility { Name = "Fervor 4d6", Level = 11 },
                new ClassAbility { Name = "Fervor 5d6", Level = 14 },
                new ClassAbility { Name = "Fervor 6d6", Level = 17 },
                new ClassAbility { Name = "Fervor 7d6", Level = 20 },
                new ClassAbility { Name = "Bonus Feat", Level = 3 },
                new ClassAbility { Name = "Bonus Feat", Level = 6 },
                new ClassAbility { Name = "Bonus Feat", Level = 9 },
                new ClassAbility { Name = "Bonus Feat", Level = 12 },
                new ClassAbility { Name = "Bonus Feat", Level = 15 },
                new ClassAbility { Name = "Bonus Feat", Level = 18 },
                new ClassAbility { Name = "Channel Energy", Level = 4 },
                new ClassAbility { Name = "Sacred Armor +1", Level = 7 },
                new ClassAbility { Name = "Sacred Armor +2", Level = 10 },
                new ClassAbility { Name = "Sacred Armor +3", Level = 13 },
                new ClassAbility { Name = "Sacred Armor +4", Level = 16 },
                new ClassAbility { Name = "Sacred Armor +5", Level = 19 },
                new ClassAbility { Name = "Aspect of War", Level = 20 },
            };
        }
    }
}
