using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class SilverBalladeer : Archetype
    {
        public SilverBalladeer(Classes.Bard bard)
        {
            Name = "Silver Balladeer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Break Curse",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Holy Vibration",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                },
                new ArchetypeAbility
                {
                    Name = "Mass Break Curse",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Pure Heart",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Silver Mastery",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance2 },
                }
            };
        }
    }
}
