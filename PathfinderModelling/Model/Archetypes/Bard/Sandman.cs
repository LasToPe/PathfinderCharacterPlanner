using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Sandman : Archetype
    {
        public Sandman(Classes.Bard bard)
        {
            Name = "Sandman";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Stealspell",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage"))),
                },
                new ArchetypeAbility
                {
                    Name = "Slumber Song",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Dramatic Subtext",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                },
                new ArchetypeAbility
                {
                    Name = "Greater Stealspell",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Mass Slumber Song",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Spell Catching",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { bard.DeadlyPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Master of Deception",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Sneakspell",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    // Sneak Attack
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master")))
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Competence"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Trap Sense +{Math.Round(0.33 * a.Level)}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            for (int i = 5; i <= 20; i += 5)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Sneak Attack +{i / 5}d6",
                    Level = i,
                });
        }
    }
}
