using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class AncestralHarbinger : Archetype
    {
        public AncestralHarbinger(Classes.Bloodrager bloodrager)
        {
            Name = "Ancestral Harbinger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Spirit Guardian",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge, bloodrager.BloodlineFeat6, bloodrager.BloodlineFeat18 },
                },
                new ArchetypeAbility
                {
                    Name = "Spirit Servants",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge, bloodrager.BloodlineFeat12 },
                }
            };
        }
    }
}
