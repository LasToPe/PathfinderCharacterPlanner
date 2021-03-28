using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class DervishDancer : Archetype
    {
        public DervishDancer(Classes.Bard bard)
        {
            Name = "Dervish Dancer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Battle Dance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Rain of Blows",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Razor's Kiss",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Leaf on the Wind",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Fleet",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))) { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Versatile Dance",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Dance of Fury",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Battle Fury",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { bard.DeadlyPerformance },
                }
            };
        }
    }
}
