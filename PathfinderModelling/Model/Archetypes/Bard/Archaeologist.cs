using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Archaeologist :  Archetype
    {
        public Archaeologist(Classes.Bard bard)
        {
            Name = "Archaeologist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    ReplacedAbilities = new List<ClassAbility> 
                    {
                        bard.BardicPerformance,
                        bard.Countersong,
                        bard.Distraction,
                        bard.Fascinate,
                        bard.InspireCourage1,
                        bard.InspireCourage2,
                        bard.InspireCourage3,
                        bard.InspireCourage4,
                        bard.InspireCompetence2,
                        bard.InspireCompetence3,
                        bard.InspireCompetence4,
                        bard.InspireCompetence5,
                        bard.InspireCompetence6,
                        bard.Suggestion,
                        bard.DirgeOfDoom,
                        bard.InspireGreatness,
                        bard.SoothingPerformance,
                        bard.FrighteningTune,
                        bard.InspireHeroics,
                        bard.MassSuggestion,
                        bard.DeadlyPerformance,
                    },
                },
                new ArchetypeAbility
                {
                    Name = "Archaeologist's Luck +1",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Archaeologist's Luck +2",
                    Level = 5,
                },
                new ArchetypeAbility
                {
                    Name = "Archaeologist's Luck +3",
                    Level = 11,
                },
                new ArchetypeAbility
                {
                    Name = "Archaeologist's Luck +4",
                    Level = 17,
                },
                new ArchetypeAbility
                {
                    Name = "Clever Explorer",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance2, bard.VersatilePerformance6, bard.VersatilePerformance10, bard.VersatilePerformance14, bard.VersatilePerformance18 },
                },
                new ArchetypeAbility
                {
                    Name = "Uncanny Dodge",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Evasion",
                    Level = 6,
                },
                new ArchetypeAbility
                {
                    Name = "Advanced Talents",
                    Level = 12,
                }
            };

            for (int i = 3; i < 20; i += 3)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Trap Sense +{Math.Round(0.333 * i)}",
                    Level = i,
                });

            for (int i = 4; i < 20; i += 4)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Rogue Talent",
                    Level = i,
                });
        }
    }
}
