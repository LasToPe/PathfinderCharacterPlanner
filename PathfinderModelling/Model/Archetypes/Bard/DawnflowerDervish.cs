using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class DawnflowerDervish : Archetype
    {
        public DawnflowerDervish(Classes.Bard bard)
        {
            Name = "Dawnflower Dervish";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Deity",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Battle Dance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Dervish Dance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Spinning Spellcaster",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))),
                },
                new ArchetypeAbility
                {
                    Name = "Meditative Whirl",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                }
            };
        }
    }
}
