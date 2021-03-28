using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class FeyPrankster : Archetype
    {
        public FeyPrankster(Classes.Bard bard)
        {
            Name = "Fey Prankster";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Mischievous Talent",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Song of Clumsiness",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Incite Unreliability",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage"))),
                },
                new ArchetypeAbility
                {
                    Name = "Embarrassing Satire",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Dirty Trickster",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Master of Mischief"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
