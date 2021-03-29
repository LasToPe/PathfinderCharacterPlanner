using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class CrossbloodedRager : Archetype
    {
        public CrossbloodedRager(Classes.Bloodrager bloodrager)
        {
            Name = "Crossblooded Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Drawbacks",
                    Level = 1,
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

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Bloodline Spell"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Bloodline Power"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
