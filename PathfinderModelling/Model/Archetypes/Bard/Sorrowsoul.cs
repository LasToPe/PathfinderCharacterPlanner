using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Sorrowsoul : Archetype
    {
        public Sorrowsoul(Classes.Bard bard)
        {
            Name = "Sorrowsoul";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Lyric Sorrow",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))) { bard.BardicPerformance, bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Darkness Denied",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Spurn Harm",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master")))
                }
            };
        }
    }
}
