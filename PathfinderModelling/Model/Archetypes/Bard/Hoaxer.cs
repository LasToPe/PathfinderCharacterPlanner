using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Hoaxer : Archetype
    {
        public Hoaxer(Classes.Bard bard)
        {
            Name = "Hoaxer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Counterfeiter",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Bad Deal",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage") || a.Name.Contains("Inspire Competence"))),
                },
                new ArchetypeAbility
                {
                    Name = "Buyer Beware",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Personal Guarantee",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Distraction },
                },
                new ArchetypeAbility
                {
                    Name = "Curse Breaker",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                },
                new ArchetypeAbility
                {
                    Name = "Misery",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Versed in Curses",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
            };

            for (int i = 3; i < 20; i += 3)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Bad Deal Hex",
                    Level = i,
                });

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Curse Crafter",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
