using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class BeastRider : Archetype
    {
        public BeastRider(Classes.Cavalier cavalier)
        {
            Name = "Beast Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Exotic Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount, cavalier.ExpertTrainer },
                }
            };
        }
    }
}
