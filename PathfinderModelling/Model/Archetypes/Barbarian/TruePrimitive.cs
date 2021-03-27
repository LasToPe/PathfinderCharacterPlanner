using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class TruePrimitive : Archetype
    {
        public TruePrimitive(Classes.Barbarian barbarian)
        {
            Name = "True Primitive";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Illiteracy",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Favored Terrain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Trophy Fetish",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(barbarian.ClassAbilities.Where(a => a.Name.Contains("Trap Sense"))),
                }
            };
        }
    }
}
