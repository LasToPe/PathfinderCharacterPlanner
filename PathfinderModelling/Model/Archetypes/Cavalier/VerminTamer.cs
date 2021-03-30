using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class VerminTamer : Archetype
    {
        public VerminTamer(Classes.Cavalier cavalier)
        {
            Name = "Vermin Tamer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Darklands Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Stuck in the Saddle",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Disorienting Challenge",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                }
            };
        }
    }
}
