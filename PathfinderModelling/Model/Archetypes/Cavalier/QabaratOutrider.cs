using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class QabaratOutrider : Archetype
    {
        public QabaratOutrider(Classes.Cavalier cavalier)
        {
            Name = "Qabarat Outrider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Combat Expertise",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Maneuver Tactics",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician, cavalier.GreaterTactician, cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Mindlink",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Mindlink Pulse",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                }
            };
        }
    }
}
