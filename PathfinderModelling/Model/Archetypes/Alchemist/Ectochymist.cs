using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Ectochymist : Archetype
    {
        public Ectochymist(Classes.Alchemist alchemist)
        {
            Name = "Ectochymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Ectoplasmic Blanche",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb")))
                },
                new ArchetypeAbility
                {
                    Name = "Cool-Headed +2",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2 }
                },
                new ArchetypeAbility
                {
                    Name = "Cool-Headed +4",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Cool-Headed +6",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Advanced Ectochymistry",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Swift Ectochymistry",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Ghost Trap",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery8 }
                },
                new ArchetypeAbility
                {
                    Name = "Ectochymical Analysis",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                }
            };
        }
    }
}
