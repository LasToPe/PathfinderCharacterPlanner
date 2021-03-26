using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class TrapBreaker : Archetype
    {
        public TrapBreaker(Classes.Alchemist alchemist)
        {
            Name = "Trap Breaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Trapfinding",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2 }
                },
                new ArchetypeAbility
                {
                    Name = "Explosive Disarm",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4, alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Land Mine",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Mine Engineering",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                }
            };
        }
    }
}
