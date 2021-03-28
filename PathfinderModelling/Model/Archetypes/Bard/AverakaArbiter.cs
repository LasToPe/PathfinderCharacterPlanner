using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class AverakaArbiter : Archetype
    {
        public AverakaArbiter(Classes.Bard bard)
        {
            Name = "Averaka Arbiter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Inspire Teamwork",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))),
                },
                new ArchetypeAbility
                {
                    Name = "Ritual of Reconciliation",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    // Verstile Teamwork
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Versatile Teamwork",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
