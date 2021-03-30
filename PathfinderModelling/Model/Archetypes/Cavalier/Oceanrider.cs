using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Oceanrider : Archetype
    {
        public Oceanrider(Classes.Cavalier cavalier)
        {
            Name = "Oceanrider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aquatic Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount, cavalier.ExpertTrainer },
                }
            };
        }
    }
}
