using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class CryptBreaker : Archetype
    {
        public CryptBreaker(Classes.Alchemist alchemist)
        {
            Name = "Crypt Breaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 1d8",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 2d8",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 3d8",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 4d8",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 5d8",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 6d8",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 7d8",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 8d8",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 9d8",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Alkahest Bombs 10d8",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Crypt Breaker's Draught",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Trapfinding",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Rogue Talents",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Enhanced Alkahest",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                }
            };
        }
    }
}
