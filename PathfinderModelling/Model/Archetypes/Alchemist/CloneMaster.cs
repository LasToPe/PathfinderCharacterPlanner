using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class CloneMaster : Archetype
    {
        public CloneMaster(Classes.Alchemist alchemist)
        {
            Name = "Clone Master";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bomb 1d4",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 2d4",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 3d4",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 4d4",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 5d4",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 6d4",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 7d4",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 8d4",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 9d4",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 10d4",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Lesser Simulacrum",
                    Level = 7,
                },
                new ArchetypeAbility
                {
                    Name = "Rebirth",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Simulacrum",
                    Level = 13,
                },
                new ArchetypeAbility
                {
                    Name = "Clone",
                    Level = 16,
                },
            };
        }
    }
}
