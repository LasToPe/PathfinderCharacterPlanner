using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Watersinger : Archetype
    {
        public Watersinger(Classes.Bard bard)
        {
            Name = "Watersinger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Watersong",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate, bard.Suggestion, bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Waterstrike",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))),
                },
                new ArchetypeAbility
                {
                    Name = "Lifewater",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bard.LoreMaster1 },
                },
                new ArchetypeAbility
                {
                    Name = bard.LoreMaster1.Name,
                    Level = bard.LoreMaster2.Level,
                    ReplacedAbilities = new List<ClassAbility> { bard.LoreMaster2 },
                },
                new ArchetypeAbility
                {
                    Name = bard.LoreMaster2.Name,
                    Level = bard.LoreMaster3.Level,
                    ReplacedAbilities = new List<ClassAbility> { bard.LoreMaster3 },
                },
                new ArchetypeAbility
                {
                    Name = "Watersinger Spells",
                    Level = 1,
                }
            };
        }
    }
}
