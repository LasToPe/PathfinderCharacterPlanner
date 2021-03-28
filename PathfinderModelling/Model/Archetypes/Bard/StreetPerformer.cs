using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class StreetPerformer : Archetype
    {
        public StreetPerformer(Classes.Bard bard)
        {
            Name = "Street Performer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Disappearing Act",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage")))
                },
                new ArchetypeAbility
                {
                    Name = "Harmless Performer",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence")))
                },
                new ArchetypeAbility
                {
                    Name = "Madcap Prank",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                },
                new ArchetypeAbility
                {
                    Name = "Slip through the Crowd",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Gladhanding",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Streetwise",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Quick Change"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
