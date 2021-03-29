using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class UrbanBloodrager : Archetype
    {
        public UrbanBloodrager(Classes.Bloodrager bloodrager)
        {
            Name = "Urban Bloodrager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Controlled Bloodrage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.Bloodrage },
                },
                new ArchetypeAbility
                {
                    Name = "Restrained Magic",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodSanctuary },
                },
            };

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Adopted Magic",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
