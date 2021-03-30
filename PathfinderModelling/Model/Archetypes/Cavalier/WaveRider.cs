using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class WaveRider : Archetype
    {
        public WaveRider(Classes.Cavalier cavalier)
        {
            Name = "Wave Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Seafaring Companion",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                }
            };
        }
    }
}
