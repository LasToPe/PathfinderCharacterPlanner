using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Musketeer : Archetype
    {
        public Musketeer(Classes.Cavalier cavalier)
        {
            Name = "Musketeer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Gifted Firearm",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Swift Powder",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                }
            };
        }
    }
}
