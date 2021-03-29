using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class IdRager : Archetype
    {
        public IdRager(Classes.Bloodrager bloodrager)
        {
            Name = "Id Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Atavistic Avatar",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bloodrager.ClassAbilities.Where(a => a.Name.Contains("Bloodline Spell") || a.Name.Contains("Bloodline Power"))) { bloodrager.Bloodline },
                },
                new ArchetypeAbility
                {
                    Name = "Atavistic Caster",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.Spells, bloodrager.EschewMaterials },
                },
            };

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Bloodline Feat"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
