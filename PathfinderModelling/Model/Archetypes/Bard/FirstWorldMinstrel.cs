using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class FirstWorldMinstrel : Archetype
    {
        public FirstWorldMinstrel(Classes.Bard bard)
        {
            Name = "First World Minstrel";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fey Magic",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Wild Empathy",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Echoes of the First World",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage"))),
                },
                new ArchetypeAbility
                {
                    Name = "Gremlin's Luck",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Resist Nature's Lure",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };
        }
    }
}
