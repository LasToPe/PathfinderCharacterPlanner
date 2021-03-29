using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class MetamagicRager : Archetype
    {
        public MetamagicRager(Classes.Bloodrager bloodrager)
        {
            Name = "Metamagic Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Meta-Rage",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge },
                }
            };
        }
    }
}
