using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class FlameDancer : Archetype
    {
        public FlameDancer(Classes.Bard bard)
        {
            Name = "Flame Dancer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fire Dance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Song of the Fiery Gaze",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))),
                },
                new ArchetypeAbility
                {
                    Name = "Fire Break",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Fan the Flames",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                }
            };
        }
    }
}
