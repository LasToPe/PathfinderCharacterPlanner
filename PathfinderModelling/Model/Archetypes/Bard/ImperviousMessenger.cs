using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ImperviousMessenger : Archetype
    {
        public ImperviousMessenger(Classes.Bard bard)
        {
            Name = "Impervious Messenger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Chant of Perfect Recall",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Song of Subterfuge",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Unbroken Stride",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom, bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Cryptic Whisper",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge, bard.WellVersed },
                }
            };
        }
    }
}
