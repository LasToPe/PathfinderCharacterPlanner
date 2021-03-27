using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Hurler : Archetype
    {
        public Hurler(Classes.Barbarian barbarian)
        {
            Name = "Hurler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Skilled Thrower",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                }
            };
        }
    }
}
