using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class AnimalSpeaker : Archetype
    {
        public AnimalSpeaker(Classes.Bard bard)
        {
            Name = "Animal Speaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Animal Friend",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Nature's Speaker 1",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Nature's Speaker 2",
                    Level = 11,
                },
                new ArchetypeAbility
                {
                    Name = "Nature's Speaker 3",
                    Level = 17,
                },
                new ArchetypeAbility
                {
                    Name = "Soothing Performance",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireCompetence2, bard.InspireCompetence3, bard.InspireCompetence4, bard.InspireCompetence5, bard.InspireCompetence6 },
                },
                new ArchetypeAbility
                {
                    Name = "Attract Rats",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Summon Nature's Ally",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                }
            };
        }
    }
}
