using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Breaker : Archetype
    {
        public Breaker(Classes.Barbarian barbarian)
        {
            Name = "Breaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Destructive",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Battle Scavenger",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense1, barbarian.TrapSense2, barbarian.TrapSense3, barbarian.TrapSense4, barbarian.TrapSense5, barbarian.TrapSense6 }
                }
            };
        }
    }
}
