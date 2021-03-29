using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Rageshaper : Archetype
    {
        public Rageshaper(Classes.Bloodrager bloodrager)
        {
            Name = "Rageshaper";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bestial Aspect",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodSanctuary },
                },
                new ArchetypeAbility
                {
                    Name = "Furious Transformation",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge },
                }
            };
        }
    }
}
