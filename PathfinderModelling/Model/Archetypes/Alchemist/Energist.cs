using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Energist : Archetype
    {
        public Energist(Classes.Alchemist alchemist)
        {
            Name = "Energist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Energy Focus",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Extracts }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity, alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 2d6",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 3d6",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 4d6",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 5d6",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 6d6",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 7d6",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 8d6",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 9d6",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Bombs 10d6",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Healing Ampoule",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Energist Resistance",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6 }
                }
            };
        }
    }
}
