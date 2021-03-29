using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Constable : Archetype
    {
        public Constable(Classes.Cavalier cavalier)
        {
            Name = "Constable";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Apprehend",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Squad Commander",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Quick Interrogator",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Badge",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Instant Order",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge, cavalier.SupremeCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Greater Badge",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                }
            };
        }
    }
}
