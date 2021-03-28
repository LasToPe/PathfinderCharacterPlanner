using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Wit : Archetype
    {
        public Wit(Classes.Bard bard)
        {
            Name = "Wit";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Way with Words",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Counterargument",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Cutting Remark",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))) { bard.DirgeOfDoom, bard.FrighteningTune }
                },
                new ArchetypeAbility
                {
                    Name = "Quick Witted",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance")))
                },
                new ArchetypeAbility
                {
                    Name = "Duel Master",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "On the Ball"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
