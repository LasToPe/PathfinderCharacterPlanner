using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class DirgeBard : Archetype
    {
        public DirgeBard(Classes.Bard bard)
        {
            Name = "Dirge Bard";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Dance of the Dead",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Haunted Eyes",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Haunting Refrain",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))),
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Secrets of the Grave",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
