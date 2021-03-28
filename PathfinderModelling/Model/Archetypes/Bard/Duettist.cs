using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Duettist : Archetype
    {
        public Duettist(Classes.Bard bard)
        {
            Name = "Duettist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Competency",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed, bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Familiar",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Versatile Familiar",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Performing Familiar",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))),
                },
                new ArchetypeAbility
                {
                    Name = "Harmonizing Familiar",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Symphonic Familiar",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.FrighteningTune },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
