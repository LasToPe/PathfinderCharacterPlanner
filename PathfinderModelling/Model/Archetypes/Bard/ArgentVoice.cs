using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ArgentVoice : Archetype
    {
        public ArgentVoice(Classes.Bard bard)
        {
            Name = "Argent Voice";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Limning Verse",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Shattering Crescendo",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Devilbane Refrain",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom, bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Dedicated Performance",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance2 },
                }
            };
        }
    }
}
