using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Demagogue : Archetype
    {
        public Demagogue(Classes.Bard bard)
        {
            Name = "Demagogue";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Famous",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireCourage1 },
                },
                new ArchetypeAbility
                {
                    Name = "Gather Crowd",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))),
                },
                new ArchetypeAbility
                {
                    Name = "Incite Violence",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Righteous Cause",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage") && a.Level > 1)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Inspire Courage +{Math.Round(0.167 * a.Level + 0.167)}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
