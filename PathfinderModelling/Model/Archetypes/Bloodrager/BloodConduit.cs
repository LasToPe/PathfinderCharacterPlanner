using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class BloodConduit : Archetype
    {
        public BloodConduit(Classes.Bloodrager bloodrager)
        {
            Name = "Blood Conduit";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Contact Specialist",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Spell Conduit",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge, bloodrager.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Reflexive Conduit",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.IndomitableWill },
                }
            };

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Bloodline Feat"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
