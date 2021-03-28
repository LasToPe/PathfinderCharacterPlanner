using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class VoiceOfBrigh : Archetype
    {
        public VoiceOfBrigh(Classes.Bard bard)
        {
            Name = "Voice of Brigh";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Brigh's Knowledge",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Brigh's Soothing",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Brigh's Anger",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Brigh's Spark",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Brigh's Wrath",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.FrighteningTune },
                }
            };
        }
    }
}
