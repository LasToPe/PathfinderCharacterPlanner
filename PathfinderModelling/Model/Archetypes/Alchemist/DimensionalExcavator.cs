using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class DimensionalExcavator : Archetype
    {
        public DimensionalExcavator(Classes.Alchemist alchemist)
        {
            Name = "Dimensional Excavator";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Extradimensional Extract",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 }
                },
                new ArchetypeAbility
                {
                    Name = "Precipitous Discoveries",
                    Level = 6,
                }
            };
        }
    }
}
