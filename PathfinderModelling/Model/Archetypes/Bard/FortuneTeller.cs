using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class FortuneTeller : Archetype
    {
        public FortuneTeller(Classes.Bard bard)
        {
            Name = "Fortune-Teller";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fortune-Teller's Divinations",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Oracular Performance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance, bard.Countersong, bard.Distraction },
                },
                new ArchetypeAbility
                {
                    Name = "Fortune-Teller's Acumen",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Transparent Fate",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                }
            };
        }
    }
}
