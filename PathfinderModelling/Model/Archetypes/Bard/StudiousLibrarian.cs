using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class StudiousLibrarian : Archetype
    {
        public StudiousLibrarian(Classes.Bard bard)
        {
            Name = "Studious Librarian";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Scribe Scroll",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Distraction },
                },
                new ArchetypeAbility
                {
                    Name = "Comparative Arcane Studies 1/day",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Critical Research Focus",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Perfect Recollection",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "One with the Library",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { bard.DeadlyPerformance },
                }
            };

            for (int i = 10; i < 20; i += 4)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Comparative Arcane Studies {Math.Round(0.25 * i - 0.5)}/day",
                    Level = 1,
                });
        }
    }
}
