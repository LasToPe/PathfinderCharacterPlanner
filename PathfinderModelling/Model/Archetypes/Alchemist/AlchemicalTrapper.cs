using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class AlchemicalTrapper : Archetype
    {
        public AlchemicalTrapper(Classes.Alchemist alchemist)
        {
            Name = "Alchemical Trapper";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bomb Trap",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                },
                new ArchetypeAbility
                {
                    Name = "Trapfinding",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 }
                }
            };
        }
    }
}
