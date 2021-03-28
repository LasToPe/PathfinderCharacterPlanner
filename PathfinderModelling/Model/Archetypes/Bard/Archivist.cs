using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Archivist : Archetype
    {
        public Archivist(Classes.Bard bard)
        {
            Name = "Archivist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Naturalist +1",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage"))),
                },
                new ArchetypeAbility
                {
                    Name = "Lamentable Belaborment",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Pedantic Lecture",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Magic Lore",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                // Lore Master
                new ArchetypeAbility
                {
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance")))
                },
                new ArchetypeAbility
                {
                    Name = "Jack of All Trades",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master")))
                },
                new ArchetypeAbility
                {
                    Name = "Probable Path",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                }
            };

            for (int i = 5; i < 20; i += 6)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Naturalist +{Math.Round(0.167 * i + 1.167)}",
                    Level = i,
                });

            for (int i = 2; i < 20; i += 6)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Lore Master {Math.Round(0.167 * i + 0.67)}/day",
                    Level = i,
                });
        }
    }
}
