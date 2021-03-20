using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Repository
{
    public class Alchemist
    {
        public CharacterClass Class { get; }

        public Alchemist()
        {
            Class = new CharacterClass
            {
                Name = "Alchemist",
                Alignment = "Any",
                BaseAttackBonus = BaseAttackBonus.Medium,
                BaseAttackBonusFraction = 0.75f,
                FortitudeSave = SavingThrow.Good,
                ReflexSave = SavingThrow.Good,
                WillSave = SavingThrow.Bad,
                ClassAbilities = new List<ClassAbility>
                {
                    new ClassAbility { Name = "Alchemy", Level = 1 },
                    new ClassAbility { Name = "Bomb 1d6", Level = 1 },
                    new ClassAbility { Name = "Bomb 2d6", Level = 3 },
                    new ClassAbility { Name = "Bomb 3d6", Level = 5 },
                    new ClassAbility { Name = "Bomb 4d6", Level = 7 },
                    new ClassAbility { Name = "Bomb 5d6", Level = 9 },
                    new ClassAbility { Name = "Bomb 6d6", Level = 11 },
                    new ClassAbility { Name = "Bomb 7d6", Level = 13 },
                    new ClassAbility { Name = "Bomb 8d6", Level = 15 },
                    new ClassAbility { Name = "Bomb 9d6", Level = 17 },
                    new ClassAbility { Name = "Bomb 10d6", Level = 19 },
                    new ClassAbility { Name = "Brew Potion", Level = 1 },
                    new ClassAbility { Name = "Mutagen", Level = 1 },
                    new ClassAbility { Name = "Throw Anything", Level = 1 },
                    new ClassAbility { Name = "Discovery", Level = 2 },
                    new ClassAbility { Name = "Discovery", Level = 4 },
                    new ClassAbility { Name = "Discovery", Level = 6 },
                    new ClassAbility { Name = "Discovery", Level = 8 },
                    new ClassAbility { Name = "Discovery", Level = 10 },
                    new ClassAbility { Name = "Discovery", Level = 12 },
                    new ClassAbility { Name = "Discovery", Level = 14 },
                    new ClassAbility { Name = "Discovery", Level = 16 },
                    new ClassAbility { Name = "Discovery", Level = 18 },
                    new ClassAbility { Name = "Poison Resistance +2", Level = 2 },
                    new ClassAbility { Name = "Poison Resistance +4", Level = 5 },
                    new ClassAbility { Name = "Poison Resistance +6", Level = 8 },
                    new ClassAbility { Name = "Poison Immunity", Level = 10 },
                    new ClassAbility { Name = "Poison Use", Level = 2 },
                    new ClassAbility { Name = "Swift Alchemy", Level = 3 },
                    new ClassAbility { Name = "Swift Poisoning", Level = 6 },
                    new ClassAbility { Name = "Persistent Mutagen", Level = 14 },
                    new ClassAbility { Name = "Instant Alchemy", Level = 18 },
                    new ClassAbility { Name = "Grand Discovery", Level = 20 },
                }
            };
        }
    }
}
