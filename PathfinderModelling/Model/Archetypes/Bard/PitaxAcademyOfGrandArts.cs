using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class PitaxAcademyOfGrandArts : Archetype
    {
        public PitaxAcademyOfGrandArts(Classes.Bard bard)
        {
            Name = "Pitax: Academy of Grand Arts";
            ArchetypeAbilities = new List<ArchetypeAbility>();

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Focused Performance",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
