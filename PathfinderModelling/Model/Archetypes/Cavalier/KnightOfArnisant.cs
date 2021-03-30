using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class KnightOfArnisant : Archetype
    {
        public KnightOfArnisant(Classes.Cavalier cavalier)
        {
            Name = "Knight of Arnisant";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Shield Expertise",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Deflective Shield",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Heraldic Banner",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Soul Shield",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Defensive Challenge",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                },
                new ArchetypeAbility
                {
                    Name = "Heart Shield",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                }
            };
        }
    }
}
