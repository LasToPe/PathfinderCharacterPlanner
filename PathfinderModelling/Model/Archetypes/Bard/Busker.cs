using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Busker : Archetype
    {
        public Busker(Classes.Bard bard)
        {
            Name = "Busker";
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
                    Name = "Busker Stunts",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Quick Hands +1",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Patter",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Living Statue",
                    Level = 3,
                },
                new ArchetypeAbility
                {
                    Name = "Fascinate",
                    Level = 6,
                },
                new ArchetypeAbility
                {
                    Name = "Suggestion",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Inventive Juggler",
                    Level = 9,
                },
                new ArchetypeAbility
                {
                    Name = "Impossible Sleight of Hand",
                    Level = 15,
                },
                new ArchetypeAbility
                {
                    Name = "Flexible Performer",
                    Level = 1,
                }
            };

            for (int i = 5; i < 20; i += 6)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Quick Hands +{Math.Round(0.167 * i + 1.167)}",
                    Level = i,
                });
        }
    }
}
