using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Aquachymist : Archetype
    {
        public Aquachymist(Classes.Alchemist alchemist)
        {
            Name = "Aquachymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Sureseal Alchemy",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 2d6",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 3d6",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 4d6",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 5d6",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 6d6",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 7d6",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 8d6",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 9d6",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Underwater Bombs 10d6",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Amphibious Mutagen",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                },
            };
        }
    }
}
