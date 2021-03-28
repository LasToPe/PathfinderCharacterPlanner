using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class LuringPiper : Archetype
    {
        public LuringPiper(Classes.Bard bard)
        {
            Name = "Luring Piper";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fey Secrets",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Luring Presentation",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Charming Melody",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Deadly Lure",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Fey-Wounding Song",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Piper's Attention",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };
        }
    }
}
