using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Concocter : Archetype
    {
        public Concocter(Classes.Alchemist alchemist)
        {
            Name = "Concocter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Mutagenic Mixology",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2, alchemist.Discovery4 }
                },
                new ArchetypeAbility
                {
                    Name = "Extracting Mixology",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery6 }
                }
            };
        }
    }
}
