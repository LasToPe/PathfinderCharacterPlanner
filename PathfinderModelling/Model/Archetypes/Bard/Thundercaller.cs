using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Thundercaller : Archetype
    {
        public Thundercaller(Classes.Bard bard)
        {
            Name = "Thundercaller";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bound to the Land",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Thunder Call",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence")))
                },
                new ArchetypeAbility
                {
                    Name = "Incite Rage",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Call Lightning",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Call Lightning Storm",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.FrighteningTune },
                }
            };
        }
    }
}
