using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class HeraldSquire : Archetype
    {
        public HeraldSquire(Classes.Cavalier cavalier)
        {
            Name = "Herald Squire";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Introduction",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Fleet of Foot",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.OrderAbility2 },
                },
                new ArchetypeAbility
                {
                    Name = "Transcend Language",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                }
            };
        }
    }
}
