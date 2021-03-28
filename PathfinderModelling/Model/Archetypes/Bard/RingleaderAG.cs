using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class RingleaderAG : Archetype
    {
        public RingleaderAG(Classes.Bard bard)
        {
            Name = "Ringleader (AG)";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Cunning Plan",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Never Lose Face",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Sinister Mien",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Countless Contingencies",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion, bard.SoothingPerformance },
                }
            };
        }
    }
}
