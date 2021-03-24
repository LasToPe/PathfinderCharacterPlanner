using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class AlchemicalSapper : Archetype
    {
        public AlchemicalSapper(Classes.Alchemist alchemist)
        {
            Name = "Alchemical Sapper";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Alchemy",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Alchemy },
                    Add = () => alchemist.LimitedExtracts(true),
                    Remove = () => alchemist.LimitedExtracts(false),
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 2d6",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 3d6",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 4d6",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 5d6",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 6d6",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 7d6",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 8d6",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 9d6",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bombs 10d6",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bomb 1/day",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bomb 2/day",
                    Level = 5,
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bomb 3/day",
                    Level = 9,
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bomb 4/day",
                    Level = 13,
                },
                new ArchetypeAbility
                {
                    Name = "Demolition Bomb 5/day",
                    Level = 17,
                },
                new ArchetypeAbility
                {
                    Name = "Delayed Bomb",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Master Engineer",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Poison Resistance")))
                },
                new ArchetypeAbility
                {
                    Name = "Camouflage Bomb",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Trip Mine",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery6 }
                },
                new ArchetypeAbility
                {
                    Name = "Selective Detonation",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                }
            };
        }
    }
}
