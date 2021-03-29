using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Primalist : Archetype
    {
        public Primalist(Classes.Bloodrager bloodrager)
        {
            Name = "Primalist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bloodline",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.Bloodline },
                },
                new ArchetypeAbility
                {
                    Name = "Primal Choices",
                    Level = 4,
                }
            };
        }
    }
}
