using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Juggler : Archetype
    {
        public Juggler(Classes.Bard bard)
        {
            Name = "Juggler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fast Reactions",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))) { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Combat Juggling",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Evasion",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed, bard.SoothingPerformance },
                }
            };
        }
    }
}
