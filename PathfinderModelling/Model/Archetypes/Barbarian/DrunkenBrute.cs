using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class DrunkenBrute : Archetype
    {
        public DrunkenBrute(Classes.Barbarian barbarian)
        {
            Name = "Drunken Brute";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Raging Drunk",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                }
            };
        }
    }
}
