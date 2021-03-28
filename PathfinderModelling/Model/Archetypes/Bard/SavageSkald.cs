using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class SavageSkald : Archetype
    {
        public SavageSkald(Classes.Bard bard)
        {
            Name = "Savage Skald";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Inspiring Blow",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Incite Rage",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Song of the Fallen",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Berserkergang",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Battle Song",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                }
            };
        }
    }
}
