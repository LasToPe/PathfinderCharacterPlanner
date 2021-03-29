using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Gallant : Archetype
    {
        public Gallant(Classes.Cavalier cavalier)
        {
            Name = "Gallant";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Code of Gallantry",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Order },
                },
                new ArchetypeAbility
                {
                    Name = "Symbol of Inspiration",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Symbol of Resilience",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                }
            };
        }
    }
}
