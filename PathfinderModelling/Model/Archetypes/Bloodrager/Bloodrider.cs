using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Bloodrider : Archetype
    {
        public Bloodrider(Classes.Bloodrager bloodrager)
        {
            Name = "Bloodrider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fast Rider",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Feral Mount",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge, bloodrager.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Blood Bond",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat9 },
                }
            };
        }
    }
}
