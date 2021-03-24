using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Blightseeker : Archetype
    {
        public Blightseeker(Classes.Alchemist alchemist)
        {
            Name = "Blightseeker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 1d4",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 2d4",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 3d4",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 4d4",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 5d4",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 6d4",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 7d4",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 8d4",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 9d4",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Spore Bomb 10d4",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Blights",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery6, alchemist.Discovery12, alchemist.Discovery18 }
                },
                new ArchetypeAbility
                {
                    Name = "Blight Engineering",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                },
            };
        }
    }
}
